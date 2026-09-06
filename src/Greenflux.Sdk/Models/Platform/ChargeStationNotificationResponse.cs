using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class ChargeStationNotificationResponse
{
    [JsonPropertyName("data")]
    public ChargeStationNotification? Data { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public DateTimeOffset Timestamp { get; set; } = default!;

    [JsonPropertyName("status_code")]
    [JsonRequired]
    public OcpiStatusCode StatusCode { get; set; } = default!;

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
}

