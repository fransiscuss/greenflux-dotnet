using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiAuthRule
{
    [JsonPropertyName("type")]
    public GcpiAuthRuleType? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
