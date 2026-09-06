using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class PutPspTokenRequest
{

    [JsonPropertyName("pspPaymentMethodId")]
    public string? PspPaymentMethodId { get; set; }

    [JsonPropertyName("customerOrWalletId")]
    public string? CustomerOrWalletId { get; set; }

    [JsonPropertyName("cardAlias")]
    public string? CardAlias { get; set; }

    [JsonPropertyName("cardNumberHint")]
    public string? CardNumberHint { get; set; }

    [JsonPropertyName("cardType")]
    public PutPspTokenRequestCardType? CardType { get; set; }

}
