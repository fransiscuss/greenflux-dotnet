#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class Connector
{
    [JsonProperty("id", Required = Required.AllowNull)]
    public string? Id { get; set; } = default!;

    [JsonProperty("standard", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectorType Standard { get; set; } = default!;

    [JsonProperty("format", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectorFormat Format { get; set; } = default!;

    [JsonProperty("power_type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public PowerType Power_type { get; set; } = default!;

    [JsonProperty("voltage", Required = Required.AllowNull)]
    public int? Voltage { get; set; } = default!;

    [JsonProperty("amperage", Required = Required.AllowNull)]
    public int? Amperage { get; set; } = default!;

    [JsonProperty("max_electric_power", NullValueHandling = NullValueHandling.Ignore)]
    public int? Max_electric_power { get; set; } = default!;

    [JsonProperty("tariff_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Tariff_id { get; set; } = default!;

    [JsonProperty("terms_and_conditions", NullValueHandling = NullValueHandling.Ignore)]
    public string? Terms_and_conditions { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.AllowNull)]
    public DateTimeOffset? Last_updated { get; set; } = default!;
}

