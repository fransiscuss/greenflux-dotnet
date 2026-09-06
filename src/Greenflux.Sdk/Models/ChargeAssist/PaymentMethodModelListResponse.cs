using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class PaymentMethodModelListResponse
{

    [JsonPropertyName("data")]
    public ICollection<PaymentMethodModel>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
