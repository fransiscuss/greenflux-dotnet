#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SessionRatingV2Model
{

    [JsonProperty("sessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SessionId { get; set; } = default!;

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("ratingOptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? RatingOptions { get; set; } = default!;

    [JsonProperty("feedbackText", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FeedbackText { get; set; } = default!;

    [JsonProperty("starRating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StarRating { get; set; } = default!;

}
