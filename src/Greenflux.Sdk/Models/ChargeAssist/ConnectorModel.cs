using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class ConnectorModel
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("standard")]
    public ConnectorModelStandard? Standard { get; set; }

    [JsonPropertyName("format")]
    public ConnectorModelFormat? Format { get; set; }

    [JsonPropertyName("powerType")]
    public ConnectorModelPowerType? PowerType { get; set; }

    [JsonPropertyName("phases")]
    public int? Phases { get; set; }

    [JsonPropertyName("kw")]
    public int? Kw { get; set; }

    [JsonPropertyName("powerInKw")]
    public double? PowerInKw { get; set; }

    [JsonPropertyName("voltage")]
    public int? Voltage { get; set; }

    [JsonPropertyName("amperage")]
    public int? Amperage { get; set; }

    [JsonPropertyName("tariffId")]
    public string? TariffId { get; set; }

    [JsonPropertyName("termsAndConditions")]
    public string? TermsAndConditions { get; set; }

    [JsonPropertyName("matchesFilter")]
    public bool? MatchesFilter { get; set; }

}
