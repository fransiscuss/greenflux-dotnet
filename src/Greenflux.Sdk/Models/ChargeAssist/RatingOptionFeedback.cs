#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class RatingOptionFeedback
{

    [JsonProperty("ratingOptionKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RatingOptionKey { get; set; } = default!;

    [JsonProperty("subRatingOptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? SubRatingOptions { get; set; } = default!;

    [JsonProperty("feedbackText", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FeedbackText { get; set; } = default!;

}
