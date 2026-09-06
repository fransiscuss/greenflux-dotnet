using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SessionLocationCoordinatesModel
{

    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

}
