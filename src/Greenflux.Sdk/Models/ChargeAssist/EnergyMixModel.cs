#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class EnergyMixModel
{

    [JsonProperty("isGreenEnergy", Required = Required.Always)]
    public bool IsGreenEnergy { get; set; } = default!;

    [JsonProperty("energySources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EnergySourceModel>? EnergySources { get; set; } = default!;

    [JsonProperty("environImpact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EnvironmentalImpactModel>? EnvironImpact { get; set; } = default!;

    [JsonProperty("supplierName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } = default!;

    [JsonProperty("energyProductName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EnergyProductName { get; set; } = default!;

}
