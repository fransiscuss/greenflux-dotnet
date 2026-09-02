#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class LocationMinModel
{

    [JsonProperty("lat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Lat { get; set; } = default!;

    [JsonProperty("lon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Lon { get; set; } = default!;

    [JsonProperty("locationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("evsesCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EvsesCount { get; set; } = default!;

    [JsonProperty("evsesAvailableCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EvsesAvailableCount { get; set; } = default!;

}
