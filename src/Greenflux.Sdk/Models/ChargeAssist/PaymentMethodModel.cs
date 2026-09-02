#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class PaymentMethodModel
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("externalPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExternalPaymentMethodId { get; set; } = default!;

    [JsonProperty("cardAlias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardAlias { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public PaymentMethodModelType? Type { get; set; } = default!;

    [JsonProperty("chargeCardIssuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeCardIssuer { get; set; } = default!;

    [JsonProperty("cardHint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardHint { get; set; } = default!;

    [JsonProperty("cardShortHint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardShortHint { get; set; } = default!;

    [JsonProperty("cardExpiryHint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardExpiryHint { get; set; } = default!;

    [JsonProperty("authId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuthId { get; set; } = default!;

    [JsonProperty("isCompatible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCompatible { get; set; } = default!;

    [JsonProperty("isVidMapped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsVidMapped { get; set; } = default!;

    [JsonProperty("isAccountPaymentMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAccountPaymentMethod { get; set; } = default!;

    [JsonProperty("verificationStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public PaymentMethodModelVerificationStatus? VerificationStatus { get; set; } = default!;

    [JsonProperty("driverName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DriverName { get; set; } = default!;

    [JsonProperty("linkedPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedPaymentMethodId { get; set; } = default!;

    [JsonProperty("linkedPaymentMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public LinkedPaymentMethod? LinkedPaymentMethod { get; set; } = default!;

    [JsonProperty("expirationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationDate { get; set; } = default!;

    [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDate { get; set; } = default!;

    [JsonProperty("isDefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDefault { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

    [JsonProperty("preferredNetwork", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PreferredNetwork { get; set; } = default!;

    [JsonProperty("isValid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsValid { get; set; } = default!;

}
