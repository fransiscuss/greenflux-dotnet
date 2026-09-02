#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class SessionRatingV2Request
{

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("sessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SessionId { get; set; } = default!;

    [JsonProperty("starRating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StarRating { get; set; } = default!;

}
