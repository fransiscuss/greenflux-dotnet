using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiCommandResponse
{
    [JsonPropertyName("result")]
    public GcpiCommandResponseType? Result { get; set; }

    [JsonPropertyName("charge_station_notification_id")]
    public string? ChargeStationNotificationId { get; set; }
}
