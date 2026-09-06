using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class SessionTransactionDetailsModel
{

    [JsonPropertyName("paymentMethod")]
    public SessionPaymentMethodModel? PaymentMethod { get; set; }

    [JsonPropertyName("pspTransactionId")]
    public string? PspTransactionId { get; set; }

    [JsonPropertyName("totalCostsCharged")]
    public double? TotalCostsCharged { get; set; }

    [JsonPropertyName("paymentConfirmationTime")]
    public DateTimeOffset? PaymentConfirmationTime { get; set; }

    [JsonPropertyName("paymentStatus")]
    public SessionTransactionDetailsModelPaymentStatus? PaymentStatus { get; set; }

    [JsonPropertyName("creditWalletId")]
    public string? CreditWalletId { get; set; }

    [JsonPropertyName("externalCdrId")]
    public string? ExternalCdrId { get; set; }

}
