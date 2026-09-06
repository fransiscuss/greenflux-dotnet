using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Greenflux.Json;

/// <summary>
/// Serializes enums as the string value declared by their <see cref="EnumMemberAttribute"/>,
/// falling back to the member name when there is none.
/// </summary>
/// <remarks>
/// System.Text.Json does not honour <see cref="EnumMemberAttribute"/> on the target
/// frameworks this SDK supports, so the wire values published by the upstream APIs
/// (<c>CHADEMO</c>, <c>AC_1_PHASE</c>, …) need this converter to round-trip.
/// </remarks>
public sealed class EnumMemberJsonConverter : JsonConverterFactory
{
    /// <inheritdoc />
    public override bool CanConvert(Type typeToConvert)
    {
        ArgumentNullException.ThrowIfNull(typeToConvert);
        return typeToConvert.IsEnum;
    }

    /// <inheritdoc />
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        ArgumentNullException.ThrowIfNull(typeToConvert);
        var converterType = typeof(EnumMemberJsonConverter<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }
}

/// <summary>Converts a single enum type to and from its <see cref="EnumMemberAttribute"/> value.</summary>
/// <typeparam name="TEnum">The enum type.</typeparam>
public sealed class EnumMemberJsonConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    private static readonly Dictionary<TEnum, string> NamesByValue = BuildNames();
    private static readonly Dictionary<string, TEnum> ValuesByName =
        BuildValues(NamesByValue);

    /// <inheritdoc />
    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
        {
            // Newtonsoft's StringEnumConverter accepted numeric values; keep doing so.
            var numeric = reader.GetInt64();
            return (TEnum)Enum.ToObject(typeof(TEnum), numeric);
        }

        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException(
                $"Expected a string or number when reading {typeof(TEnum).Name} but found {reader.TokenType}.");
        }

        var text = reader.GetString();
        if (text is not null && ValuesByName.TryGetValue(text, out var value))
        {
            return value;
        }

        throw new JsonException($"'{text}' is not a recognised value for {typeof(TEnum).Name}.");
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        ArgumentNullException.ThrowIfNull(writer);

        if (NamesByValue.TryGetValue(value, out var name))
        {
            writer.WriteStringValue(name);
            return;
        }

        writer.WriteStringValue(value.ToString());
    }

    private static Dictionary<TEnum, string> BuildNames()
    {
        var map = new Dictionary<TEnum, string>();
        foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var value = (TEnum)field.GetValue(null)!;
            var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
            map[value] = attribute?.Value ?? field.Name;
        }

        return map;
    }

    private static Dictionary<string, TEnum> BuildValues(Dictionary<TEnum, string> namesByValue)
    {
        var map = new Dictionary<string, TEnum>(StringComparer.OrdinalIgnoreCase);
        foreach (var pair in namesByValue)
        {
            map[pair.Value] = pair.Key;
        }

        // Also accept the C# member name, which is what a caller reading our own
        // enum declarations would reasonably send.
        foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var value = (TEnum)field.GetValue(null)!;
            map.TryAdd(field.Name, value);
        }

        return map;
    }
}
