using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Tariff
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    [JsonPropertyName("currency")]
    [JsonRequired]
    public string Currency { get; set; } = default!;

    [JsonPropertyName("tariff_alt_text")]
    public ICollection<DisplayText>? TariffAltText { get; set; }

    [JsonPropertyName("tariff_alt_url")]
    public string? TariffAltUrl { get; set; }

    [JsonPropertyName("elements")]
    public ICollection<TariffElement>? Elements { get; set; }

    [JsonPropertyName("energy_mix")]
    public EnergyMix? EnergyMix { get; set; }

    [JsonPropertyName("last_updated")]
    [JsonRequired]
    public DateTimeOffset LastUpdated { get; set; } = default!;
}

