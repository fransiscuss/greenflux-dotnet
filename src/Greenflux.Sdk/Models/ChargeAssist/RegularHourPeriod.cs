#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class RegularHourPeriod
{

    [JsonProperty("periodBegin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PeriodBegin { get; set; } = default!;

    [JsonProperty("periodEnd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PeriodEnd { get; set; } = default!;

}
