using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class LinkedPaymentMethod
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public LinkedPaymentMethodType? Type { get; set; }

    [JsonPropertyName("cardHint")]
    public string? CardHint { get; set; }

}
