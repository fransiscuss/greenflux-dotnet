using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class RetryFailedSessionPaymentRequest
{

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("paymentMethodId")]
    public string? PaymentMethodId { get; set; }

}
