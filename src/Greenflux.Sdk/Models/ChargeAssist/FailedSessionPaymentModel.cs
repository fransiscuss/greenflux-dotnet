using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class FailedSessionPaymentModel
{

    [JsonPropertyName("chargeSessionId")]
    public string? ChargeSessionId { get; set; }

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("paymentMethodId")]
    public string? PaymentMethodId { get; set; }

    [JsonPropertyName("paymentStatus")]
    public FailedSessionPaymentModelPaymentStatus? PaymentStatus { get; set; }

    [JsonPropertyName("totalCost")]
    public double? TotalCost { get; set; }

    [JsonPropertyName("transactionTime")]
    public DateTimeOffset? TransactionTime { get; set; }

    [JsonPropertyName("lastAttemptedTime")]
    public DateTimeOffset? LastAttemptedTime { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

}
