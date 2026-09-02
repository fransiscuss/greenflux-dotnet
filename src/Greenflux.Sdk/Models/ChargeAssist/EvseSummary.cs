#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class EvseSummary
{

    [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("chargerType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargerType { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EvseSummaryStatus? Status { get; set; } = default!;

    [JsonProperty("agreement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agreement { get; set; } = default!;

    [JsonProperty("connectors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ConnectorSummary>? Connectors { get; set; } = default!;

    [JsonProperty("evseId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseId { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

}
