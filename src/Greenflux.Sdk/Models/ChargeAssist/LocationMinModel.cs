using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class LocationMinModel
{

    [JsonPropertyName("lat")]
    public double? Lat { get; set; }

    [JsonPropertyName("lon")]
    public double? Lon { get; set; }

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evsesCount")]
    public int? EvsesCount { get; set; }

    [JsonPropertyName("evsesAvailableCount")]
    public int? EvsesAvailableCount { get; set; }

}
