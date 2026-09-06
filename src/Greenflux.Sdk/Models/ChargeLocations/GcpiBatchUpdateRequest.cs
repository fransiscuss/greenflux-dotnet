using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchUpdateRequest
{
    [JsonPropertyName("charge_station_ids")]
    public ICollection<string>? ChargeStationIds { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("reset_on_accepted")]
    public bool? ResetOnAccepted { get; set; }

    [JsonPropertyName("retries")]
    public int? Retries { get; set; }

    [JsonPropertyName("delay")]
    public int? Delay { get; set; }
}
