using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SessionHistoryV2ModelListResponse
{

    [JsonPropertyName("data")]
    public ICollection<SessionHistoryV2Model>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
