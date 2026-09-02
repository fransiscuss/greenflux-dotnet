#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class LinkChargeCardRequest
{

    [JsonProperty("chargeCardPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeCardPaymentMethodId { get; set; } = default!;

    [JsonProperty("linkPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkPaymentMethodId { get; set; } = default!;

}
