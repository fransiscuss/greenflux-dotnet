using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class AdditionalGeoLocation
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("latitude")]
    [JsonRequired]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    [JsonRequired]
    public string? Longitude { get; set; }
}

