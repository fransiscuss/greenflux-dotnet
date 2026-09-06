using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class PutExternalPaymentMethodRequest
{

    [JsonPropertyName("externalPaymentMethodId")]
    [JsonRequired]
    public string ExternalPaymentMethodId { get; set; } = default!;

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

}
