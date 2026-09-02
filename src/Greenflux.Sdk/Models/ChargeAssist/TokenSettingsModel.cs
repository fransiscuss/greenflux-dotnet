#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class TokenSettingsModel
{

    [JsonProperty("defaultPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPaymentMethodId { get; set; } = default!;

    [JsonProperty("defaultLanguageCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultLanguageCode { get; set; } = default!;

}
