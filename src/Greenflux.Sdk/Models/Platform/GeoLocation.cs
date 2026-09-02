#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class GeoLocation
{
    [JsonProperty("latitude", Required = Required.Always)]
    public string Latitude { get; set; } = default!;

    [JsonProperty("longitude", Required = Required.Always)]
    public string Longitude { get; set; } = default!;
}

