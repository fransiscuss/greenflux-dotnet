#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class SessionTransactionDetailsModel
{

    [JsonProperty("paymentMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionPaymentMethodModel? PaymentMethod { get; set; } = default!;

    [JsonProperty("pspTransactionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PspTransactionId { get; set; } = default!;

    [JsonProperty("totalCostsCharged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostsCharged { get; set; } = default!;

    [JsonProperty("paymentConfirmationTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PaymentConfirmationTime { get; set; } = default!;

    [JsonProperty("paymentStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SessionTransactionDetailsModelPaymentStatus? PaymentStatus { get; set; } = default!;

    [JsonProperty("creditWalletId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreditWalletId { get; set; } = default!;

    [JsonProperty("externalCdrId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExternalCdrId { get; set; } = default!;

}
