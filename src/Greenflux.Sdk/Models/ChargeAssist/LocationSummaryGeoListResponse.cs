using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationSummaryGeoListResponse
{

    [JsonPropertyName("boundingBox")]
    public BoundingBox? BoundingBox { get; set; }

    [JsonPropertyName("data")]
    public ICollection<LocationSummary>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
