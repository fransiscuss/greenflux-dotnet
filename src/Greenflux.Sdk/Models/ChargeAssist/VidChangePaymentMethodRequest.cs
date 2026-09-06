using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class VidChangePaymentMethodRequest
{

    [JsonPropertyName("paymentMethodId")]
    [JsonRequired]
    public string? PaymentMethodId { get; set; }

}
