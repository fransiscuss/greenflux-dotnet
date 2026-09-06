using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class GeoLocation
{
    [JsonPropertyName("latitude")]
    [JsonRequired]
    public string Latitude { get; set; } = default!;

    [JsonPropertyName("longitude")]
    [JsonRequired]
    public string Longitude { get; set; } = default!;
}

