using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class BoundingBox
{

    [JsonPropertyName("bottomLeftLat")]
    public double? BottomLeftLat { get; set; }

    [JsonPropertyName("bottomLeftLng")]
    public double? BottomLeftLng { get; set; }

    [JsonPropertyName("topRightLat")]
    public double? TopRightLat { get; set; }

    [JsonPropertyName("topRightLng")]
    public double? TopRightLng { get; set; }

}
