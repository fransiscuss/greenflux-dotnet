using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class EnvironmentalImpactModel
{

    [JsonPropertyName("source")]
    [JsonRequired]
    public EnvironmentalImpactModelSource Source { get; set; } = default!;

    [JsonPropertyName("amount")]
    [JsonRequired]
    public double Amount { get; set; } = default!;

}
