#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class FailedSessionPaymentModel
{

    [JsonProperty("chargeSessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeSessionId { get; set; } = default!;

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("paymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentMethodId { get; set; } = default!;

    [JsonProperty("paymentStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public FailedSessionPaymentModelPaymentStatus? PaymentStatus { get; set; } = default!;

    [JsonProperty("totalCost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCost { get; set; } = default!;

    [JsonProperty("transactionTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TransactionTime { get; set; } = default!;

    [JsonProperty("lastAttemptedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastAttemptedTime { get; set; } = default!;

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Error { get; set; } = default!;

}
