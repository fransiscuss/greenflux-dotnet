using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class FailedSessionPaymentModelListResponse
{

    [JsonPropertyName("data")]
    public ICollection<FailedSessionPaymentModel>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
