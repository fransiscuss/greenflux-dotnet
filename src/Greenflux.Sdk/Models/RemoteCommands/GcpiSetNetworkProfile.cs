using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiSetNetworkProfile
{
    [JsonPropertyName("charge_station_id")]
    [JsonRequired]
    public string ChargeStationId { get; set; } = default!;

    [JsonPropertyName("configuration_slot")]
    [JsonRequired]
    public int ConfigurationSlot { get; set; } = default!;

    [JsonPropertyName("connection_data")]
    [JsonRequired]
    public GcpiNetworkConnectionProfile ConnectionData { get; set; } = new GcpiNetworkConnectionProfile();
}
