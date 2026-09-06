using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class StatusResponse
{

    [JsonPropertyName("sessionId")]
    [JsonRequired]
    public string? SessionId { get; set; }

    [JsonPropertyName("appToken")]
    [JsonRequired]
    public string? AppToken { get; set; }

    [JsonPropertyName("externalSessionId")]
    public string? ExternalSessionId { get; set; }

    [JsonPropertyName("locationId")]
    [JsonRequired]
    public string? LocationId { get; set; }

    [JsonPropertyName("evseUid")]
    [JsonRequired]
    public string? EvseUid { get; set; }

    [JsonPropertyName("connectorId")]
    [JsonRequired]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("authId")]
    public string? AuthId { get; set; }

    [JsonPropertyName("status")]
    public StatusResponseStatus? Status { get; set; }

    [JsonPropertyName("canRateSession")]
    public bool? CanRateSession { get; set; }

    [JsonPropertyName("error")]
    public StatusResponseError? Error { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("energyInKwh")]
    public double? EnergyInKwh { get; set; }

    [JsonPropertyName("currentPowerInKw")]
    public double? CurrentPowerInKw { get; set; }

    [JsonPropertyName("totalCosts")]
    public double? TotalCosts { get; set; }

    [JsonPropertyName("totalVat")]
    public double? TotalVat { get; set; }

    [JsonPropertyName("vatPercentage")]
    public double? VatPercentage { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public DateTimeOffset? EndTime { get; set; }

    [JsonPropertyName("nextStatusCall")]
    public DateTimeOffset? NextStatusCall { get; set; }

    [JsonPropertyName("usageSummary")]
    public SessionDataPointsSummaryModel? UsageSummary { get; set; }

    [JsonPropertyName("smartChargingEnabled")]
    public bool? SmartChargingEnabled { get; set; }

    [JsonPropertyName("prioritySessionStatus")]
    public StatusResponsePrioritySessionStatus? PrioritySessionStatus { get; set; }

    [JsonPropertyName("vidStatus")]
    public StatusResponseVidStatus? VidStatus { get; set; }

    [JsonPropertyName("paymentMethodId")]
    [JsonRequired]
    public string? PaymentMethodId { get; set; }

    [JsonPropertyName("paymentMethod")]
    public SessionPaymentMethodModel? PaymentMethod { get; set; }

    [JsonPropertyName("chargingNotAllowed")]
    public bool? ChargingNotAllowed { get; set; }

    [JsonPropertyName("stateOfCharge")]
    public double? StateOfCharge { get; set; }

    [JsonPropertyName("receiptNumber")]
    public string? ReceiptNumber { get; set; }

    [JsonPropertyName("couponStatus")]
    public StatusResponseCouponStatus? CouponStatus { get; set; }

    [JsonPropertyName("mileage")]
    public string? Mileage { get; set; }

    [JsonPropertyName("startMethod")]
    public StatusResponseStartMethod? StartMethod { get; set; }

    [JsonPropertyName("transactionDetails")]
    public SessionTransactionDetailsModel? TransactionDetails { get; set; }

    [JsonPropertyName("pspPreAuthTransactionId")]
    public string? PspPreAuthTransactionId { get; set; }

    [JsonPropertyName("isPrivateCharger")]
    public bool? IsPrivateCharger { get; set; }

    [JsonPropertyName("location")]
    public SessionLocationModel? Location { get; set; }

    [JsonPropertyName("costBreakdown")]
    public CdrCostBreakdown? CostBreakdown { get; set; }

}
