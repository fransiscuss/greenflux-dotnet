using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class EnergySource
{
    [JsonPropertyName("source")]
    [JsonRequired]
    public EnergySourceCategory Source { get; set; } = default!;

    [JsonPropertyName("percentage")]
    [JsonRequired]
    public double? Percentage { get; set; }
}

