using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SessionRatingAllV2Request
{

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    [JsonPropertyName("feedbackText")]
    public string? FeedbackText { get; set; }

    [JsonPropertyName("ratingOptions")]
    public ICollection<string>? RatingOptions { get; set; }

    [JsonPropertyName("starRating")]
    public int? StarRating { get; set; }

}
