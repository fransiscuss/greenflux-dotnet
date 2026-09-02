#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class GeoLocationModel
{

    [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Latitude { get; set; } = default!;

    [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Longitude { get; set; } = default!;

}
