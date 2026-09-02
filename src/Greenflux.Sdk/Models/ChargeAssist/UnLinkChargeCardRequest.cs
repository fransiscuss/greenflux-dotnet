#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class UnLinkChargeCardRequest
{

    [JsonProperty("chargeCardPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeCardPaymentMethodId { get; set; } = default!;

}
