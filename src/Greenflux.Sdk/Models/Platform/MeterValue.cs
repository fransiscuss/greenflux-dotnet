#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class MeterValue
{
    [JsonProperty("meter_value_uid", Required = Required.Always)]
    public string Meter_value_uid { get; set; } = default!;

    [JsonProperty("value", Required = Required.Always)]
    public double Value { get; set; } = default!;

    [JsonProperty("unit", Required = Required.Always)]
    public string Unit { get; set; } = default!;

    [JsonProperty("evse_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Evse_id { get; set; } = default!;

    [JsonProperty("charge_station_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_station_id { get; set; } = default!;

    [JsonProperty("meter_type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public MeterType Meter_type { get; set; } = default!;

    [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_id { get; set; } = default!;

    [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Session_id { get; set; } = default!;

    [JsonProperty("connector_ID", NullValueHandling = NullValueHandling.Ignore)]
    public string? Connector_ID { get; set; } = default!;

    [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
    public string? Context { get; set; } = default!;

    [JsonProperty("measurand", NullValueHandling = NullValueHandling.Ignore)]
    public string? Measurand { get; set; } = default!;

    [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
    public string? Phase { get; set; } = default!;

    [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
    public string? Format { get; set; } = default!;

    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationMeterValue? Location { get; set; } = default!;

    [JsonProperty("created", Required = Required.Always)]
    public DateTimeOffset Created { get; set; } = default!;

    [JsonProperty("timestamp", Required = Required.Always)]
    public DateTimeOffset Timestamp { get; set; } = default!;

    [Obsolete]
    [JsonProperty("meter_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Meter_id { get; set; } = default!;
}

