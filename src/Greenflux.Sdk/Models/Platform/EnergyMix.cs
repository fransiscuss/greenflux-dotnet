#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class EnergyMix
{
    [JsonProperty("is_green_energy", Required = Required.AllowNull)]
    public bool? Is_green_energy { get; set; } = default!;

    [JsonProperty("energy_sources", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EnergySource>? Energy_sources { get; set; } = default!;

    [JsonProperty("environ_impact", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EnvironmentalImpact>? Environ_impact { get; set; } = default!;

    [JsonProperty("supplier_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } = default!;

    [JsonProperty("energy_product_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Energy_product_name { get; set; } = default!;
}

