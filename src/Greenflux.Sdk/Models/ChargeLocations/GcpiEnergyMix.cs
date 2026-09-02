#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiEnergyMix
{
    [JsonProperty("energy_mix_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Energy_mix_profile_id { get; set; } = default!;

    [JsonProperty("is_green_energy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_green_energy { get; set; } = default!;

    [JsonProperty("energy_sources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiEnergySource>? Energy_sources { get; set; } = default!;

    [JsonProperty("environ_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiEnvironmentalImpact>? Environ_impact { get; set; } = default!;

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } = default!;

    [JsonProperty("energy_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Energy_product_name { get; set; } = default!;
}
