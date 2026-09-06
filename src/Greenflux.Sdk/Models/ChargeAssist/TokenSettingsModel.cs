using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class TokenSettingsModel
{

    [JsonPropertyName("defaultPaymentMethodId")]
    public string? DefaultPaymentMethodId { get; set; }

    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

}
