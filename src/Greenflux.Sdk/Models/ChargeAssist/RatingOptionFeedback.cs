using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class RatingOptionFeedback
{

    [JsonPropertyName("ratingOptionKey")]
    public string? RatingOptionKey { get; set; }

    [JsonPropertyName("subRatingOptions")]
    public ICollection<string>? SubRatingOptions { get; set; }

    [JsonPropertyName("feedbackText")]
    public string? FeedbackText { get; set; }

}
