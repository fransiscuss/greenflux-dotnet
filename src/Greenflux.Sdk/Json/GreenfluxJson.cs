using System.Text.Json;
using System.Text.Json.Serialization;

namespace Greenflux.Json;

/// <summary>The JSON configuration the SDK uses for every request and response.</summary>
public static class GreenfluxJson
{
    /// <summary>
    /// Shared serializer options. Reuse these when reading or writing SDK models
    /// yourself, so enum values and null handling match what the clients do.
    /// </summary>
    public static JsonSerializerOptions Options { get; } = Create();

    private static JsonSerializerOptions Create()
    {
        var options = new JsonSerializerOptions
        {
            // Null properties are omitted from request bodies rather than sent explicitly.
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            PropertyNameCaseInsensitive = true,
            // Newtonsoft coerced quoted numbers; the upstream APIs rely on that
            // (OCPI sends coordinates as strings), so keep reading them.
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };
        options.Converters.Add(new EnumMemberJsonConverter());
        return options;
    }
}
