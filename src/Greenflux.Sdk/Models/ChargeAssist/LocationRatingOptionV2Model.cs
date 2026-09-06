using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationRatingOptionV2Model
{

    [JsonPropertyName("subRatingOptions")]
    public ICollection<SubRatingOptionModel>? SubRatingOptions { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

}
