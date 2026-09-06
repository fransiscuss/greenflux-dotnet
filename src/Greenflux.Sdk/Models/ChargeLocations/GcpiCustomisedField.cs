using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiCustomisedField
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
