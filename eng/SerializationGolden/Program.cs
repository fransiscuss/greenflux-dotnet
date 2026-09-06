using System.Collections;
using System.Globalization;
using System.Reflection;
using Greenflux.Http;

// Captures the serialized form of every public model in the SDK, so a serializer
// change can be proved to preserve the wire contract: run before and after, diff.
//
// The filler seeds values from each property's JSON name (not its C# name), so the
// output is stable across C# identifier renames - only a real wire-format change moves it.

var outputDir = args.Length > 0
    ? args[0]
    : Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "golden");
outputDir = Path.GetFullPath(outputDir);
Directory.CreateDirectory(outputDir);

var assembly = typeof(GreenfluxApiClient).Assembly;
var modelTypes = assembly.GetExportedTypes()
    .Where(t => t.IsClass && !t.IsAbstract && t.Namespace is not null)
    .Where(t => t.Namespace!.StartsWith("Greenflux.", StringComparison.Ordinal))
    .Where(t => !t.Namespace!.Contains(".Http", StringComparison.Ordinal))
    .Where(t => !t.Namespace!.Contains(".Json", StringComparison.Ordinal))
    .Where(t => !t.ContainsGenericParameters)
    .Where(t => t.GetConstructor(Type.EmptyTypes) is not null)
    .Where(t => !typeof(Exception).IsAssignableFrom(t))
    .Where(t => !t.Name.EndsWith("Client", StringComparison.Ordinal))
    .OrderBy(t => t.FullName, StringComparer.Ordinal)
    .ToList();

Console.WriteLine($"Serializer: {Serializer.Name}");
Console.WriteLine($"Model types: {modelTypes.Count}");

var written = 0;
var skipped = new List<string>();
var manifest = new List<string>();

foreach (var type in modelTypes)
{
    try
    {
        var instance = Filler.Build(type, depth: 0, new HashSet<Type>());
        if (instance is null) { skipped.Add($"{type.FullName}: could not construct"); continue; }

        var json = Serializer.Serialize(instance);
        var file = Path.Combine(outputDir, Sanitize(type.FullName!) + ".json");
        File.WriteAllText(file, json.ReplaceLineEndings("\n"));
        manifest.Add($"{type.FullName}\t{Hash(json)}");
        written++;
    }
    catch (Exception ex)
    {
        skipped.Add($"{type.FullName}: {ex.GetType().Name}: {ex.Message}");
    }
}

File.WriteAllText(Path.Combine(outputDir, "_manifest.tsv"),
    string.Join("\n", manifest) + "\n");
File.WriteAllText(Path.Combine(outputDir, "_skipped.txt"),
    string.Join("\n", skipped) + "\n");

Console.WriteLine($"Written: {written}");
Console.WriteLine($"Skipped: {skipped.Count}");
foreach (var s in skipped.Take(15)) Console.WriteLine("  " + s);
if (skipped.Count > 15) Console.WriteLine($"  ... and {skipped.Count - 15} more (see _skipped.txt)");

static string Sanitize(string name) => name.Replace('+', '-');

static string Hash(string value)
{
    var bytes = System.Security.Cryptography.SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(value));
    return Convert.ToHexString(bytes)[..16];
}

internal static class Filler
{
    private const int MaxDepth = 3;

    public static object? Build(Type type, int depth, HashSet<Type> stack)
    {
        if (type.GetConstructor(Type.EmptyTypes) is null) return null;
        var instance = Activator.CreateInstance(type);
        if (instance is null) return null;

        foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (!property.CanWrite || property.GetIndexParameters().Length > 0) continue;
            var seed = JsonName(property);
            var value = Value(property.PropertyType, seed, depth, stack);
            if (value is not null) property.SetValue(instance, value);
        }

        return instance;
    }

    // Reads the JSON name from whichever serializer attribute is in play, so the
    // tool itself does not need to change when the serializer does.
    private static string JsonName(PropertyInfo property)
    {
        foreach (var attribute in property.GetCustomAttributes())
        {
            var name = attribute.GetType().Name;
            if (name is not ("JsonPropertyAttribute" or "JsonPropertyNameAttribute")) continue;
            var value = attribute.GetType().GetProperty("PropertyName")?.GetValue(attribute)
                        ?? attribute.GetType().GetProperty("Name")?.GetValue(attribute);
            if (value is string s && s.Length > 0) return s;
        }
        return property.Name;
    }

    private static object? Value(Type type, string seed, int depth, HashSet<Type> stack)
    {
        var underlying = Nullable.GetUnderlyingType(type);
        if (underlying is not null) return Value(underlying, seed, depth, stack);

        if (type == typeof(string)) return "v_" + seed;
        if (type == typeof(bool)) return StableInt(seed) % 2 == 0;
        if (type == typeof(int)) return StableInt(seed) % 1000;
        if (type == typeof(long)) return (long)(StableInt(seed) % 100000);
        if (type == typeof(short)) return (short)(StableInt(seed) % 100);
        if (type == typeof(byte)) return (byte)(StableInt(seed) % 200);
        if (type == typeof(double)) return Math.Round(StableInt(seed) % 1000 + 0.5, 2);
        if (type == typeof(float)) return (float)Math.Round(StableInt(seed) % 100 + 0.25, 2);
        if (type == typeof(decimal)) return decimal.Round(StableInt(seed) % 1000 + 0.75m, 2);
        if (type == typeof(Guid)) return DeterministicGuid(seed);
        if (type == typeof(DateTime)) return new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(StableInt(seed) % 86400);
        if (type == typeof(DateTimeOffset)) return new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero).AddSeconds(StableInt(seed) % 86400);
        if (type == typeof(TimeSpan)) return TimeSpan.FromMinutes(StableInt(seed) % 600);
        if (type == typeof(Uri)) return new Uri("https://example.test/" + seed);
        if (type == typeof(object)) return "o_" + seed;
        if (type.IsEnum) return Enum.GetValues(type).GetValue(0);

        if (depth >= MaxDepth) return null;

        if (typeof(IDictionary).IsAssignableFrom(type) || IsGeneric(type, typeof(IDictionary<,>)))
            return BuildDictionary(type, seed, depth, stack);

        if (type.IsArray)
        {
            var element = type.GetElementType()!;
            var item = Value(element, seed + "_0", depth + 1, stack);
            var array = Array.CreateInstance(element, item is null ? 0 : 1);
            if (item is not null) array.SetValue(item, 0);
            return array;
        }

        if (IsEnumerableOf(type, out var itemType))
            return BuildList(type, itemType, seed, depth, stack);

        if (type.IsClass)
        {
            if (!stack.Add(type)) return null;
            try { return Build(type, depth + 1, stack); }
            finally { stack.Remove(type); }
        }

        return null;
    }

    private static object? BuildDictionary(Type type, string seed, int depth, HashSet<Type> stack)
    {
        var args = type.IsGenericType ? type.GetGenericArguments() : [typeof(string), typeof(object)];
        if (args.Length != 2) return null;
        var concrete = typeof(Dictionary<,>).MakeGenericType(args);
        if (!type.IsAssignableFrom(concrete)) return null;
        var dictionary = (IDictionary)Activator.CreateInstance(concrete)!;
        var key = args[0] == typeof(string) ? "k_" + seed : Value(args[0], seed, depth + 1, stack);
        var value = Value(args[1], seed + "_v", depth + 1, stack);
        if (key is not null && value is not null) dictionary[key] = value;
        return dictionary;
    }

    private static object? BuildList(Type type, Type itemType, string seed, int depth, HashSet<Type> stack)
    {
        var concrete = typeof(List<>).MakeGenericType(itemType);
        if (!type.IsAssignableFrom(concrete)) return null;
        var list = (IList)Activator.CreateInstance(concrete)!;
        var item = Value(itemType, seed + "_0", depth + 1, stack);
        if (item is not null) list.Add(item);
        return list;
    }

    private static bool IsGeneric(Type type, Type definition) =>
        type.IsGenericType && type.GetGenericTypeDefinition() == definition;

    private static bool IsEnumerableOf(Type type, out Type itemType)
    {
        itemType = typeof(object);
        if (type == typeof(string)) return false;
        var candidate = type.IsGenericType && typeof(IEnumerable).IsAssignableFrom(type)
            ? type
            : type.GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>));
        if (candidate is null || !candidate.IsGenericType) return false;
        var args = candidate.GetGenericArguments();
        if (args.Length != 1) return false;
        itemType = args[0];
        return true;
    }

    private static int StableInt(string seed)
    {
        unchecked
        {
            var hash = 17;
            foreach (var c in seed) hash = (hash * 31) + c;
            return Math.Abs(hash);
        }
    }

    private static Guid DeterministicGuid(string seed)
    {
        // Not security-sensitive: just a stable Guid per seed so golden output is reproducible.
        var bytes = System.Security.Cryptography.SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(seed));
        return new Guid(bytes.AsSpan(0, 16));
    }
}
