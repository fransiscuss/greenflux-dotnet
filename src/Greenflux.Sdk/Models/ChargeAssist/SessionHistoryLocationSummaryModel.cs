using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SessionHistoryLocationSummaryModel
{

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("connectorId")]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("coordinates")]
    public SessionLocationCoordinatesModel? Coordinates { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("powerType")]
    public SessionHistoryLocationSummaryModelPowerType? PowerType { get; set; }

    [JsonPropertyName("branding")]
    public SessionBrandingModel? Branding { get; set; }

}
