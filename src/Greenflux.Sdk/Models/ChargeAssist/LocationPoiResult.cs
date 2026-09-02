#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationPoiResult
{

    [JsonProperty("lat", Required = Required.Always)]
    public double Lat { get; set; } = default!;

    [JsonProperty("lon", Required = Required.Always)]
    public double Lon { get; set; } = default!;

    [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Count { get; set; } = default!;

    [JsonProperty("dCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DCount { get; set; } = default!;

    [JsonProperty("locationIds", Required = Required.AllowNull)]
    public ICollection<string>? LocationIds { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationPoiResultType? Type { get; set; } = default!;

    [JsonProperty("x", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? X { get; set; } = default!;

    [JsonProperty("y", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Y { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationPoiResultStatus? Status { get; set; } = default!;

    [JsonProperty("evsAvailCnt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EvsAvailCnt { get; set; } = default!;

    [JsonProperty("evsCnt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EvsCnt { get; set; } = default!;

}
