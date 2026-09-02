#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchUpdateRequest
{
    [JsonProperty("charge_station_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Charge_station_ids { get; set; } = default!;

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } = default!;

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } = default!;

    [JsonProperty("reset_on_accepted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reset_on_accepted { get; set; } = default!;

    [JsonProperty("retries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Retries { get; set; } = default!;

    [JsonProperty("delay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Delay { get; set; } = default!;
}
