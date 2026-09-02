#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class PaymentStatusRequest
{

    [JsonProperty("externalCdrId", Required = Required.Always)]
    public string ExternalCdrId { get; set; } = default!;

    [JsonProperty("transactionTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TransactionTime { get; set; } = default!;

    [JsonProperty("paymentStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public PaymentStatusRequestPaymentStatus? PaymentStatus { get; set; } = default!;

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Error { get; set; } = default!;

}
