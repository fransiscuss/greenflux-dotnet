#pragma warning disable CS1591
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class ExceptionalPeriodModel
{

    [JsonProperty("periodBegin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PeriodBegin { get; set; } = default!;

    [JsonProperty("periodEnd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PeriodEnd { get; set; } = default!;

}
