using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class SessionHistoryModel
{

    [JsonPropertyName("chargeSessionId")]
    public string? ChargeSessionId { get; set; }

    [JsonPropertyName("status")]
    public SessionHistoryModelStatus? Status { get; set; }

    [JsonPropertyName("location")]
    public LocationModel? Location { get; set; }

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("connectorId")]
    public string? ConnectorId { get; set; }

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

    [JsonPropertyName("hasMoreDetails")]
    public bool? HasMoreDetails { get; set; }

    [JsonPropertyName("paymentConfirmationTime")]
    public DateTimeOffset? PaymentConfirmationTime { get; set; }

    [JsonPropertyName("vidStatus")]
    public SessionHistoryModelVidStatus? VidStatus { get; set; }

}
