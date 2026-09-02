#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class RetryFailedSessionPaymentRequest
{

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("paymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentMethodId { get; set; } = default!;

}
