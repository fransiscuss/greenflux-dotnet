using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class TariffMinSettingModel
{

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("minimumZoomLevel")]
    public int? MinimumZoomLevel { get; set; }

    [JsonPropertyName("maximumNumberOfLocations")]
    public int? MaximumNumberOfLocations { get; set; }

}
