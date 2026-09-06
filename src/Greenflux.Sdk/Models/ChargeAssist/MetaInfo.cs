using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class MetaInfo
{

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; set; }

    [JsonPropertyName("continuationToken")]
    public string? ContinuationToken { get; set; }

}
