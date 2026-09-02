#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class SessionDataPointModel
{

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;

    [JsonProperty("energyInKwh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? EnergyInKwh { get; set; } = default!;

    [JsonProperty("powerInKw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PowerInKw { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SessionDataPointModelStatus? Status { get; set; } = default!;

    [JsonProperty("stateOfCharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? StateOfCharge { get; set; } = default!;

}
