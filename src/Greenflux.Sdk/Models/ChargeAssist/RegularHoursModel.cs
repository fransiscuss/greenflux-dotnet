#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class RegularHoursModel
{

    [JsonProperty("weekday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Weekday { get; set; } = default!;

    [JsonProperty("periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RegularHourPeriod>? Periods { get; set; } = default!;

}
