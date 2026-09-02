#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class PutPspTokenRequest
{

    [JsonProperty("pspPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PspPaymentMethodId { get; set; } = default!;

    [JsonProperty("customerOrWalletId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerOrWalletId { get; set; } = default!;

    [JsonProperty("cardAlias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardAlias { get; set; } = default!;

    [JsonProperty("cardNumberHint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardNumberHint { get; set; } = default!;

    [JsonProperty("cardType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public PutPspTokenRequestCardType? CardType { get; set; } = default!;

}
