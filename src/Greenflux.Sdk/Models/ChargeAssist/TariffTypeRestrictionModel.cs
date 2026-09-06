using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class TariffTypeRestrictionModel
{

    [JsonPropertyName("min")]
    public double? Min { get; set; }

    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min_kwh")]
    public double? MinKwh { get; set; }

    [JsonPropertyName("max_kwh")]
    public double? MaxKwh { get; set; }

    [JsonPropertyName("min_duration")]
    public double? MinDuration { get; set; }

    [JsonPropertyName("max_duration")]
    public double? MaxDuration { get; set; }

    [JsonPropertyName("min_power")]
    public double? MinPower { get; set; }

    [JsonPropertyName("max_power")]
    public double? MaxPower { get; set; }

    [JsonPropertyName("min_current")]
    public double? MinCurrent { get; set; }

    [JsonPropertyName("max_current")]
    public double? MaxCurrent { get; set; }

}
