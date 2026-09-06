using System.Text.Json;
using Greenflux.Json;

// The only serializer-specific part of this tool. It deliberately borrows the SDK's own
// options rather than re-declaring them, so the golden output reflects what the SDK
// actually does on the wire.
internal static class Serializer
{
    public static string Name => "System.Text.Json";

    private static readonly JsonSerializerOptions Indented =
        new(GreenfluxJson.Options) { WriteIndented = true };

    public static string Serialize(object value) => JsonSerializer.Serialize(value, Indented);
}
