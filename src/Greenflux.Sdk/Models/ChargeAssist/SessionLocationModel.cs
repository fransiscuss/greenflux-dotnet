using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SessionLocationModel
{

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
    public SessionLocationModelPowerType? PowerType { get; set; }

    [JsonPropertyName("branding")]
    public SessionBrandingModel? Branding { get; set; }

}
