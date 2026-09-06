using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiDisplayText
{
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
