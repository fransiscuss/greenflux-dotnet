#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiGeoLocation
{
    [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Latitude { get; set; } = default!;

    [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Longitude { get; set; } = default!;
}
