#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SessionDataPointsSummaryModel
{

    [JsonProperty("maxEnergyInKwh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MaxEnergyInKwh { get; set; } = default!;

    [JsonProperty("maxPowerInKw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MaxPowerInKw { get; set; } = default!;

    [JsonProperty("minEnergyInKwh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MinEnergyInKwh { get; set; } = default!;

    [JsonProperty("minPowerInKw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MinPowerInKw { get; set; } = default!;

    [JsonProperty("dataPoints", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SessionDataPointModel>? DataPoints { get; set; } = default!;

}
