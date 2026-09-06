using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SessionDataPointsSummaryModel
{

    [JsonPropertyName("maxEnergyInKwh")]
    public double? MaxEnergyInKwh { get; set; }

    [JsonPropertyName("maxPowerInKw")]
    public double? MaxPowerInKw { get; set; }

    [JsonPropertyName("minEnergyInKwh")]
    public double? MinEnergyInKwh { get; set; }

    [JsonPropertyName("minPowerInKw")]
    public double? MinPowerInKw { get; set; }

    [JsonPropertyName("dataPoints")]
    public ICollection<SessionDataPointModel>? DataPoints { get; set; }

}
