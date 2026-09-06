using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class StartRequest
{

    [JsonPropertyName("locationId")]
    [JsonRequired]
    public string LocationId { get; set; } = default!;

    [JsonPropertyName("evseUid")]
    [JsonRequired]
    public string EvseUid { get; set; } = default!;

    [JsonPropertyName("connectorId")]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("paymentMethodId")]
    [JsonRequired]
    public string PaymentMethodId { get; set; } = default!;

    [JsonPropertyName("adhocPaymentMethodId")]
    public string? AdhocPaymentMethodId { get; set; }

    [JsonPropertyName("isPinned")]
    [System.Obsolete]
    public bool? IsPinned { get; set; }

    [JsonPropertyName("ignoreEvseAvailablity")]
    public bool? IgnoreEvseAvailablity { get; set; }

}
