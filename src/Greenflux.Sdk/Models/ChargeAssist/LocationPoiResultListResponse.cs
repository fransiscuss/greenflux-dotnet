using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationPoiResultListResponse
{

    [JsonPropertyName("data")]
    public ICollection<LocationPoiResult>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
