#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class AdditionalGeoLocation
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("latitude", Required = Required.AllowNull)]
    public string? Latitude { get; set; } = default!;

    [JsonProperty("longitude", Required = Required.AllowNull)]
    public string? Longitude { get; set; } = default!;
}

