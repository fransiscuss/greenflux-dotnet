#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class Tariff
{
    [JsonProperty("id", Required = Required.Always)]
    public string Id { get; set; } = default!;

    [JsonProperty("currency", Required = Required.Always)]
    public string Currency { get; set; } = default!;

    [JsonProperty("tariff_alt_text", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DisplayText>? Tariff_alt_text { get; set; } = default!;

    [JsonProperty("tariff_alt_url", NullValueHandling = NullValueHandling.Ignore)]
    public string? Tariff_alt_url { get; set; } = default!;

    [JsonProperty("elements", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TariffElement>? Elements { get; set; } = default!;

    [JsonProperty("energy_mix", NullValueHandling = NullValueHandling.Ignore)]
    public EnergyMix? Energy_mix { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Always)]
    public DateTimeOffset Last_updated { get; set; } = default!;
}

