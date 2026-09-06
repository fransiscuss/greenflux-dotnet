using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TokenModelListResponse
{

    [JsonPropertyName("data")]
    public ICollection<TokenModel>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
