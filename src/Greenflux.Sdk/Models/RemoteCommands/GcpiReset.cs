using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiReset
{
    [JsonPropertyName("charge_station_id")]
    [JsonRequired]
    public string? ChargeStationId { get; set; }

    [JsonPropertyName("evse_uid")]
    [JsonRequired]
    public string? EvseUid { get; set; }

    [JsonPropertyName("type")]
    [JsonRequired]
    public GcpiResetType Type { get; set; } = default!;

    [JsonPropertyName("scheduled")]
    public GcpiResetEnumType? Scheduled { get; set; }
}
