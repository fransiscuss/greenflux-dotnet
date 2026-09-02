#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class StatusResponse
{

    [JsonProperty("sessionId", Required = Required.AllowNull)]
    public string? SessionId { get; set; } = default!;

    [JsonProperty("appToken", Required = Required.AllowNull)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("externalSessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExternalSessionId { get; set; } = default!;

    [JsonProperty("locationId", Required = Required.AllowNull)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.AllowNull)]
    public string? EvseUid { get; set; } = default!;

    [JsonProperty("connectorId", Required = Required.AllowNull)]
    public string? ConnectorId { get; set; } = default!;

    [JsonProperty("authId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuthId { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public StatusResponseStatus? Status { get; set; } = default!;

    [JsonProperty("canRateSession", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanRateSession { get; set; } = default!;

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public StatusResponseError? Error { get; set; } = default!;

    [JsonProperty("errorMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ErrorMessage { get; set; } = default!;

    [JsonProperty("energyInKwh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? EnergyInKwh { get; set; } = default!;

    [JsonProperty("currentPowerInKw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrentPowerInKw { get; set; } = default!;

    [JsonProperty("totalCosts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCosts { get; set; } = default!;

    [JsonProperty("totalVat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalVat { get; set; } = default!;

    [JsonProperty("vatPercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? VatPercentage { get; set; } = default!;

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } = default!;

    [JsonProperty("startTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartTime { get; set; } = default!;

    [JsonProperty("endTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndTime { get; set; } = default!;

    [JsonProperty("nextStatusCall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextStatusCall { get; set; } = default!;

    [JsonProperty("usageSummary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionDataPointsSummaryModel? UsageSummary { get; set; } = default!;

    [JsonProperty("smartChargingEnabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SmartChargingEnabled { get; set; } = default!;

    [JsonProperty("prioritySessionStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public StatusResponsePrioritySessionStatus? PrioritySessionStatus { get; set; } = default!;

    [JsonProperty("vidStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public StatusResponseVidStatus? VidStatus { get; set; } = default!;

    [JsonProperty("paymentMethodId", Required = Required.AllowNull)]
    public string? PaymentMethodId { get; set; } = default!;

    [JsonProperty("paymentMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionPaymentMethodModel? PaymentMethod { get; set; } = default!;

    [JsonProperty("chargingNotAllowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ChargingNotAllowed { get; set; } = default!;

    [JsonProperty("stateOfCharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? StateOfCharge { get; set; } = default!;

    [JsonProperty("receiptNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReceiptNumber { get; set; } = default!;

    [JsonProperty("couponStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public StatusResponseCouponStatus? CouponStatus { get; set; } = default!;

    [JsonProperty("mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mileage { get; set; } = default!;

    [JsonProperty("startMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public StatusResponseStartMethod? StartMethod { get; set; } = default!;

    [JsonProperty("transactionDetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionTransactionDetailsModel? TransactionDetails { get; set; } = default!;

    [JsonProperty("pspPreAuthTransactionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PspPreAuthTransactionId { get; set; } = default!;

    [JsonProperty("isPrivateCharger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPrivateCharger { get; set; } = default!;

    [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionLocationModel? Location { get; set; } = default!;

    [JsonProperty("costBreakdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public CdrCostBreakdown? CostBreakdown { get; set; } = default!;

}
