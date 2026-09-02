#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class SessionHistoryModel
{

    [JsonProperty("chargeSessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeSessionId { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SessionHistoryModelStatus? Status { get; set; } = default!;

    [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public LocationModel? Location { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseUid { get; set; } = default!;

    [JsonProperty("connectorId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectorId { get; set; } = default!;

    [JsonProperty("paymentMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PaymentMethodModel? PaymentMethod { get; set; } = default!;

    [JsonProperty("startTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartTime { get; set; } = default!;

    [JsonProperty("endTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndTime { get; set; } = default!;

    [JsonProperty("retailCostInclVat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RetailCostInclVat { get; set; } = default!;

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } = default!;

    [JsonProperty("energyInKwh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? EnergyInKwh { get; set; } = default!;

    [JsonProperty("vatAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? VatAmount { get; set; } = default!;

    [JsonProperty("vatPercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? VatPercentage { get; set; } = default!;

    [JsonProperty("prioritySessionEnabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrioritySessionEnabled { get; set; } = default!;

    [JsonProperty("hasMoreDetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasMoreDetails { get; set; } = default!;

    [JsonProperty("paymentConfirmationTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PaymentConfirmationTime { get; set; } = default!;

    [JsonProperty("vidStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SessionHistoryModelVidStatus? VidStatus { get; set; } = default!;

}
