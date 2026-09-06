using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class LinkChargeCardRequest
{

    [JsonPropertyName("chargeCardPaymentMethodId")]
    public string? ChargeCardPaymentMethodId { get; set; }

    [JsonPropertyName("linkPaymentMethodId")]
    public string? LinkPaymentMethodId { get; set; }

}
