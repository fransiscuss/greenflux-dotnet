using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SubRatingOptionModel
{

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

}
