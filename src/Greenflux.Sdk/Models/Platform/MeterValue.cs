using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class MeterValue
{
    [JsonPropertyName("meter_value_uid")]
    [JsonRequired]
    public string MeterValueUid { get; set; } = default!;

    [JsonPropertyName("value")]
    [JsonRequired]
    public double Value { get; set; } = default!;

    [JsonPropertyName("unit")]
    [JsonRequired]
    public string Unit { get; set; } = default!;

    [JsonPropertyName("evse_id")]
    public string? EvseId { get; set; }

    [JsonPropertyName("charge_station_id")]
    public string? ChargeStationId { get; set; }

    [JsonPropertyName("meter_type")]
    [JsonRequired]
    public MeterType MeterType { get; set; } = default!;

    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }

    [JsonPropertyName("connector_ID")]
    public string? ConnectorID { get; set; }

    [JsonPropertyName("context")]
    public string? Context { get; set; }

    [JsonPropertyName("measurand")]
    public string? Measurand { get; set; }

    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("location")]
    public LocationMeterValue? Location { get; set; }

    [JsonPropertyName("created")]
    [JsonRequired]
    public DateTimeOffset Created { get; set; } = default!;

    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public DateTimeOffset Timestamp { get; set; } = default!;

    [Obsolete]
    [JsonPropertyName("meter_id")]
    public string? MeterId { get; set; }
}

