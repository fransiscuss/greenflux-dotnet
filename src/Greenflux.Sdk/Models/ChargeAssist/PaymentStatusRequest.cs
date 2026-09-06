using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class PaymentStatusRequest
{

    [JsonPropertyName("externalCdrId")]
    [JsonRequired]
    public string ExternalCdrId { get; set; } = default!;

    [JsonPropertyName("transactionTime")]
    public DateTimeOffset? TransactionTime { get; set; }

    [JsonPropertyName("paymentStatus")]
    public PaymentStatusRequestPaymentStatus? PaymentStatus { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

}
