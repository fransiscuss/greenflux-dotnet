#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class BoundingBox
{

    [JsonProperty("bottomLeftLat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BottomLeftLat { get; set; } = default!;

    [JsonProperty("bottomLeftLng", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BottomLeftLng { get; set; } = default!;

    [JsonProperty("topRightLat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TopRightLat { get; set; } = default!;

    [JsonProperty("topRightLng", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TopRightLng { get; set; } = default!;

}
