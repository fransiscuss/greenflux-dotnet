using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiUnlockConnector
{
    [JsonPropertyName("location_id")]
    [JsonRequired]
    public string? LocationId { get; set; }

    [JsonPropertyName("evse_uid")]
    [JsonRequired]
    public string? EvseUid { get; set; }

    [JsonPropertyName("connector_id")]
    [JsonRequired]
    public string? ConnectorId { get; set; }
}
