using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiCommandResult
{
    [JsonPropertyName("result")]
    public GcpiCommandResultType? Result { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("request")]
    public object? Request { get; set; }

    [JsonPropertyName("charge_station_notification_id")]
    public string? ChargeStationNotificationId { get; set; }
}
