using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationPoiResult
{

    [JsonPropertyName("lat")]
    [JsonRequired]
    public double Lat { get; set; } = default!;

    [JsonPropertyName("lon")]
    [JsonRequired]
    public double Lon { get; set; } = default!;

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("dCount")]
    public string? DCount { get; set; }

    [JsonPropertyName("locationIds")]
    [JsonRequired]
    public ICollection<string>? LocationIds { get; set; }

    [JsonPropertyName("type")]
    public LocationPoiResultType? Type { get; set; }

    [JsonPropertyName("x")]
    public int? X { get; set; }

    [JsonPropertyName("y")]
    public int? Y { get; set; }

    [JsonPropertyName("status")]
    public LocationPoiResultStatus? Status { get; set; }

    [JsonPropertyName("evsAvailCnt")]
    public int? EvsAvailCnt { get; set; }

    [JsonPropertyName("evsCnt")]
    public int? EvsCnt { get; set; }

}
