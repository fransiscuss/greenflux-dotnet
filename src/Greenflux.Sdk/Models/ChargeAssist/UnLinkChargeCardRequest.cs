using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class UnLinkChargeCardRequest
{

    [JsonPropertyName("chargeCardPaymentMethodId")]
    public string? ChargeCardPaymentMethodId { get; set; }

}
