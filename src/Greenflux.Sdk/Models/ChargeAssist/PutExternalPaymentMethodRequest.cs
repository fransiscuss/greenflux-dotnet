#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class PutExternalPaymentMethodRequest
{

    [JsonProperty("externalPaymentMethodId", Required = Required.Always)]
    public string ExternalPaymentMethodId { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

}
