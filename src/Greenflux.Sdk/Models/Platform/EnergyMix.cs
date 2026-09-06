using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class EnergyMix
{
    [JsonPropertyName("is_green_energy")]
    [JsonRequired]
    public bool? IsGreenEnergy { get; set; }

    [JsonPropertyName("energy_sources")]
    public ICollection<EnergySource>? EnergySources { get; set; }

    [JsonPropertyName("environ_impact")]
    public ICollection<EnvironmentalImpact>? EnvironImpact { get; set; }

    [JsonPropertyName("supplier_name")]
    public string? SupplierName { get; set; }

    [JsonPropertyName("energy_product_name")]
    public string? EnergyProductName { get; set; }
}

