using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiEnvironmentalImpact
{
    [JsonPropertyName("source")]
    public GcpiEnvironmentalImpactCategory? Source { get; set; }

    [JsonPropertyName("amount")]
    public double? Amount { get; set; }
}
