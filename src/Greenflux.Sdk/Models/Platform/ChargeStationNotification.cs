using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class ChargeStationNotification
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("charge_station_notification_id")]
    public string? ChargeStationNotificationId { get; set; }

    [JsonPropertyName("charge_station_id")]
    public string? ChargeStationId { get; set; }

    [Obsolete]
    [JsonPropertyName("charge_location_id")]
    public string? ChargeLocationId { get; set; }

    [JsonPropertyName("location_id")]
    public string? LocationId { get; set; }

    [JsonPropertyName("charge_station_message_payload")]
    public string? ChargeStationMessagePayload { get; set; }

    [JsonPropertyName("evse_id")]
    public string? EvseId { get; set; }

    [JsonPropertyName("created")]
    public DateTimeOffset? Created { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [Obsolete]
    [JsonPropertyName("messageAction")]
    public string? MessageAction { get; set; }

    [JsonPropertyName("message_Action")]
    public string? Message_Action { get; set; }

    [JsonPropertyName("message_type")]
    public string? MessageType { get; set; }
}

