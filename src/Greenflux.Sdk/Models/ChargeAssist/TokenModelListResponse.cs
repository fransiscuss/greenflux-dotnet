#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TokenModelListResponse
{

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TokenModel>? Data { get; set; } = default!;

    [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MetaInfo? Meta { get; set; } = default!;

}
