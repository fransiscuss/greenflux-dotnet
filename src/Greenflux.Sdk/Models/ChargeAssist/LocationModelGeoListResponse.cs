using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationModelGeoListResponse
{

    [JsonPropertyName("boundingBox")]
    public BoundingBox? BoundingBox { get; set; }

    [JsonPropertyName("data")]
    public ICollection<LocationModel>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
