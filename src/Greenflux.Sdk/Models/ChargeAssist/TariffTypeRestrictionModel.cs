#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class TariffTypeRestrictionModel
{

    [JsonProperty("min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Min { get; set; } = default!;

    [JsonProperty("max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Max { get; set; } = default!;

    [JsonProperty("min_kwh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_kwh { get; set; } = default!;

    [JsonProperty("max_kwh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Max_kwh { get; set; } = default!;

    [JsonProperty("min_duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_duration { get; set; } = default!;

    [JsonProperty("max_duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Max_duration { get; set; } = default!;

    [JsonProperty("min_power", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_power { get; set; } = default!;

    [JsonProperty("max_power", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Max_power { get; set; } = default!;

    [JsonProperty("min_current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_current { get; set; } = default!;

    [JsonProperty("max_current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Max_current { get; set; } = default!;

}
