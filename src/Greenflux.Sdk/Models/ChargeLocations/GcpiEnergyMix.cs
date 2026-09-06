using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiEnergyMix
{
    [JsonPropertyName("energy_mix_profile_id")]
    public string? EnergyMixProfileId { get; set; }

    [JsonPropertyName("is_green_energy")]
    public bool? IsGreenEnergy { get; set; }

    [JsonPropertyName("energy_sources")]
    public ICollection<GcpiEnergySource>? EnergySources { get; set; }

    [JsonPropertyName("environ_impact")]
    public ICollection<GcpiEnvironmentalImpact>? EnvironImpact { get; set; }

    [JsonPropertyName("supplier_name")]
    public string? SupplierName { get; set; }

    [JsonPropertyName("energy_product_name")]
    public string? EnergyProductName { get; set; }
}
