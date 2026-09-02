#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class ChargeStationNotification
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("charge_station_notification_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_station_notification_id { get; set; } = default!;

    [JsonProperty("charge_station_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_station_id { get; set; } = default!;

    [Obsolete]
    [JsonProperty("charge_location_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_location_id { get; set; } = default!;

    [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Location_id { get; set; } = default!;

    [JsonProperty("charge_station_message_payload", NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_station_message_payload { get; set; } = default!;

    [JsonProperty("evse_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Evse_id { get; set; } = default!;

    [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Created { get; set; } = default!;

    [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
    public string? Direction { get; set; } = default!;

    [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
    public string? Level { get; set; } = default!;

    [Obsolete]
    [JsonProperty("messageAction", NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageAction { get; set; } = default!;

    [JsonProperty("message_Action", NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_Action { get; set; } = default!;

    [JsonProperty("message_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_type { get; set; } = default!;
}

