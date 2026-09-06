using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SessionRatingV2Request
{

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    [JsonPropertyName("starRating")]
    public int? StarRating { get; set; }

}
