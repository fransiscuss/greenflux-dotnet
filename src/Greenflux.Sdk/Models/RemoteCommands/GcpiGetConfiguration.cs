using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiGetConfiguration
{
    [JsonPropertyName("charge_station_id")]
    [JsonRequired]
    public string ChargeStationId { get; set; } = default!;

    [JsonPropertyName("keys")]
    [JsonRequired]
    public ICollection<string> Keys { get; set; } = new Collection<string>();
}
