#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiConnector
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("standard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Standard { get; set; } = default!;

    [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Format { get; set; } = default!;

    [JsonProperty("power_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Power_type { get; set; } = default!;

    [JsonProperty("voltage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Voltage { get; set; } = default!;

    [JsonProperty("amperage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Amperage { get; set; } = default!;

    [JsonProperty("max_electric_power", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Max_electric_power { get; set; } = default!;

    [JsonProperty("tariff_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tariff_id { get; set; } = default!;

    [JsonProperty("terms_and_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Terms_and_conditions { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_updated { get; set; } = default!;

    [JsonProperty("reimbursement_tariff_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reimbursement_tariff_id { get; set; } = default!;
}
