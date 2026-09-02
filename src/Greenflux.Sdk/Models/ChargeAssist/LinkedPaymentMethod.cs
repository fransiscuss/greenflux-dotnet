#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class LinkedPaymentMethod
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LinkedPaymentMethodType? Type { get; set; } = default!;

    [JsonProperty("cardHint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardHint { get; set; } = default!;

}
