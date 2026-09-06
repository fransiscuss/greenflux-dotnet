using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SessionPaymentMethodModel
{

    [JsonPropertyName("id")]
    [JsonRequired]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public SessionPaymentMethodModelType? Type { get; set; }

    [JsonPropertyName("cardHint")]
    public string? CardHint { get; set; }

    [JsonPropertyName("chargeCardVisualNumber")]
    public string? ChargeCardVisualNumber { get; set; }

    [JsonPropertyName("externalPaymentMethodId")]
    public string? ExternalPaymentMethodId { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

}
