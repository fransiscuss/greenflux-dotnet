using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class EvseSummary
{

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("chargerType")]
    public string? ChargerType { get; set; }

    [JsonPropertyName("status")]
    public EvseSummaryStatus? Status { get; set; }

    [JsonPropertyName("agreement")]
    public bool? Agreement { get; set; }

    [JsonPropertyName("connectors")]
    public ICollection<ConnectorSummary>? Connectors { get; set; }

    [JsonPropertyName("evseId")]
    public string? EvseId { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

}
