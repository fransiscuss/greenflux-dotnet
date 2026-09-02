#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class MetaInfo
{

    [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Count { get; set; } = default!;

    [JsonProperty("hasMoreData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasMoreData { get; set; } = default!;

    [JsonProperty("continuationToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContinuationToken { get; set; } = default!;

}
