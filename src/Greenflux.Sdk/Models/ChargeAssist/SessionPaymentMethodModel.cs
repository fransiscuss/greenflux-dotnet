#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class SessionPaymentMethodModel
{

    [JsonProperty("id", Required = Required.AllowNull)]
    public string? Id { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SessionPaymentMethodModelType? Type { get; set; } = default!;

    [JsonProperty("cardHint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardHint { get; set; } = default!;

    [JsonProperty("chargeCardVisualNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeCardVisualNumber { get; set; } = default!;

    [JsonProperty("externalPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExternalPaymentMethodId { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

}
