using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class SessionHistoryV2Model
{

    [JsonPropertyName("chargeSessionId")]
    public string? ChargeSessionId { get; set; }

    [JsonPropertyName("status")]
    public SessionHistoryV2ModelStatus? Status { get; set; }

    [JsonPropertyName("paymentMethod")]
    public PaymentMethodModel? PaymentMethod { get; set; }

    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public DateTimeOffset? EndTime { get; set; }

    [JsonPropertyName("retailCostInclVat")]
    public double? RetailCostInclVat { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("energyInKwh")]
    public double? EnergyInKwh { get; set; }

    [JsonPropertyName("vatAmount")]
    public double? VatAmount { get; set; }

    [JsonPropertyName("vatPercentage")]
    public double? VatPercentage { get; set; }

    [JsonPropertyName("prioritySessionEnabled")]
    public bool? PrioritySessionEnabled { get; set; }

    [JsonPropertyName("paymentConfirmationTime")]
    public DateTimeOffset? PaymentConfirmationTime { get; set; }

    [JsonPropertyName("paymentStatus")]
    public SessionHistoryV2ModelPaymentStatus? PaymentStatus { get; set; }

    [JsonPropertyName("locationSummary")]
    public SessionHistoryLocationSummaryModel? LocationSummary { get; set; }

    [JsonPropertyName("vidStatus")]
    public SessionHistoryV2ModelVidStatus? VidStatus { get; set; }

    [JsonPropertyName("co2Saved")]
    public double? Co2Saved { get; set; }

}
