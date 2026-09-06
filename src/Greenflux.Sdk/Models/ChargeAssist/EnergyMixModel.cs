using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class EnergyMixModel
{

    [JsonPropertyName("isGreenEnergy")]
    [JsonRequired]
    public bool IsGreenEnergy { get; set; } = default!;

    [JsonPropertyName("energySources")]
    public ICollection<EnergySourceModel>? EnergySources { get; set; }

    [JsonPropertyName("environImpact")]
    public ICollection<EnvironmentalImpactModel>? EnvironImpact { get; set; }

    [JsonPropertyName("supplierName")]
    public string? SupplierName { get; set; }

    [JsonPropertyName("energyProductName")]
    public string? EnergyProductName { get; set; }

}
