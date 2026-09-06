using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class EnvironmentalImpact
{
    [JsonPropertyName("source")]
    [JsonRequired]
    public EnvironmentalImpactCategory Source { get; set; } = default!;

    [JsonPropertyName("amount")]
    [JsonRequired]
    public double? Amount { get; set; }
}

