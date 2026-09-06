using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationRatingV2Model
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("ratingOptionFeedbacks")]
    public ICollection<RatingOptionFeedback>? RatingOptionFeedbacks { get; set; }

    [JsonPropertyName("feedbackText")]
    public string? FeedbackText { get; set; }

}
