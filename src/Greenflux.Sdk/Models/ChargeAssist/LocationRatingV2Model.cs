#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationRatingV2Model
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("locationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseUid { get; set; } = default!;

    [JsonProperty("ratingOptionFeedbacks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RatingOptionFeedback>? RatingOptionFeedbacks { get; set; } = default!;

    [JsonProperty("feedbackText", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FeedbackText { get; set; } = default!;

}
