#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiConnectorTemplate
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } = default!;

    [JsonProperty("amperage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Amperage { get; set; } = default!;

    [JsonProperty("voltage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Voltage { get; set; } = default!;

    [JsonProperty("max_electric_power", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Max_electric_power { get; set; } = default!;

    [JsonProperty("standard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Standard { get; set; } = default!;

    [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Format { get; set; } = default!;

    [JsonProperty("power_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Power_type { get; set; } = default!;
}
