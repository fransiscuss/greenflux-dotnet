#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationRatingOptionV2Model
{

    [JsonProperty("subRatingOptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SubRatingOptionModel>? SubRatingOptions { get; set; } = default!;

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } = default!;

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } = default!;

}
