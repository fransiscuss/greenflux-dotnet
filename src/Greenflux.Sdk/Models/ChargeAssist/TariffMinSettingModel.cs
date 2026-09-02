#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class TariffMinSettingModel
{

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } = default!;

    [JsonProperty("minimumZoomLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinimumZoomLevel { get; set; } = default!;

    [JsonProperty("maximumNumberOfLocations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaximumNumberOfLocations { get; set; } = default!;

}
