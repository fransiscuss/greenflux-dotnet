using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class SessionDataPointModel
{

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonPropertyName("energyInKwh")]
    public double? EnergyInKwh { get; set; }

    [JsonPropertyName("powerInKw")]
    public double? PowerInKw { get; set; }

    [JsonPropertyName("status")]
    public SessionDataPointModelStatus? Status { get; set; }

    [JsonPropertyName("stateOfCharge")]
    public double? StateOfCharge { get; set; }

}
