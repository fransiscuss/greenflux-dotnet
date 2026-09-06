using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiEnergySource
{
    [JsonPropertyName("source")]
    public GcpiEnergySourceCategory? Source { get; set; }

    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}
