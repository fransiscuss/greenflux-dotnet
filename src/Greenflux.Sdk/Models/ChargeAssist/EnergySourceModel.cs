using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class EnergySourceModel
{

    [JsonPropertyName("source")]
    [JsonRequired]
    public EnergySourceModelSource Source { get; set; } = default!;

    [JsonPropertyName("percentage")]
    [JsonRequired]
    public double Percentage { get; set; } = default!;

    [JsonPropertyName("isRenewableEnergy")]
    [JsonRequired]
    public bool IsRenewableEnergy { get; set; } = default!;

}
