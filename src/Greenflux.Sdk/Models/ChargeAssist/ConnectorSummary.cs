using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class ConnectorSummary
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("standard")]
    public ConnectorSummaryStandard? Standard { get; set; }

    [JsonPropertyName("kw")]
    public int? Kw { get; set; }

    [JsonPropertyName("powerInKw")]
    public double? PowerInKw { get; set; }

    [JsonPropertyName("powerType")]
    public ConnectorSummaryPowerType? PowerType { get; set; }

}
