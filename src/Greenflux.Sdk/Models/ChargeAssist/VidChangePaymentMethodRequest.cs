#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class VidChangePaymentMethodRequest
{

    [JsonProperty("paymentMethodId", Required = Required.AllowNull)]
    public string? PaymentMethodId { get; set; } = default!;

}
