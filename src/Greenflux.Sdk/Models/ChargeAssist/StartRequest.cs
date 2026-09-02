#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class StartRequest
{

    [JsonProperty("locationId", Required = Required.Always)]
    public string LocationId { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.Always)]
    public string EvseUid { get; set; } = default!;

    [JsonProperty("connectorId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectorId { get; set; } = default!;

    [JsonProperty("paymentMethodId", Required = Required.Always)]
    public string PaymentMethodId { get; set; } = default!;

    [JsonProperty("adhocPaymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AdhocPaymentMethodId { get; set; } = default!;

    [JsonProperty("isPinned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.Obsolete]
    public bool? IsPinned { get; set; } = default!;

    [JsonProperty("ignoreEvseAvailablity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreEvseAvailablity { get; set; } = default!;

}
