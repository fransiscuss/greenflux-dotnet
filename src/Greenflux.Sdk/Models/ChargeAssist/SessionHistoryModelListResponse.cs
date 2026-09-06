using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SessionHistoryModelListResponse
{

    [JsonPropertyName("data")]
    public ICollection<SessionHistoryModel>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
