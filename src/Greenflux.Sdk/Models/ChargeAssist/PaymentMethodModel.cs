using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class PaymentMethodModel
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("externalPaymentMethodId")]
    public string? ExternalPaymentMethodId { get; set; }

    [JsonPropertyName("cardAlias")]
    public string? CardAlias { get; set; }

    [JsonPropertyName("type")]
    public PaymentMethodModelType? Type { get; set; }

    [JsonPropertyName("chargeCardIssuer")]
    public string? ChargeCardIssuer { get; set; }

    [JsonPropertyName("cardHint")]
    public string? CardHint { get; set; }

    [JsonPropertyName("cardShortHint")]
    public string? CardShortHint { get; set; }

    [JsonPropertyName("cardExpiryHint")]
    public string? CardExpiryHint { get; set; }

    [JsonPropertyName("authId")]
    public string? AuthId { get; set; }

    [JsonPropertyName("isCompatible")]
    public bool? IsCompatible { get; set; }

    [JsonPropertyName("isVidMapped")]
    public bool? IsVidMapped { get; set; }

    [JsonPropertyName("isAccountPaymentMethod")]
    public bool? IsAccountPaymentMethod { get; set; }

    [JsonPropertyName("verificationStatus")]
    public PaymentMethodModelVerificationStatus? VerificationStatus { get; set; }

    [JsonPropertyName("driverName")]
    public string? DriverName { get; set; }

    [JsonPropertyName("linkedPaymentMethodId")]
    public string? LinkedPaymentMethodId { get; set; }

    [JsonPropertyName("linkedPaymentMethod")]
    public LinkedPaymentMethod? LinkedPaymentMethod { get; set; }

    [JsonPropertyName("expirationDate")]
    public DateTimeOffset? ExpirationDate { get; set; }

    [JsonPropertyName("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("preferredNetwork")]
    public string? PreferredNetwork { get; set; }

    [JsonPropertyName("isValid")]
    public bool? IsValid { get; set; }

}
