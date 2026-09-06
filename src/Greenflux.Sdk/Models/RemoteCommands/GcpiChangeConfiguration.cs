using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiChangeConfiguration
{
    [JsonPropertyName("charge_station_id")]
    [JsonRequired]
    public string ChargeStationId { get; set; } = default!;

    [JsonPropertyName("key")]
    [JsonRequired]
    public string Key { get; set; } = default!;

    [JsonPropertyName("value")]
    [JsonRequired]
    public string Value { get; set; } = default!;
}
