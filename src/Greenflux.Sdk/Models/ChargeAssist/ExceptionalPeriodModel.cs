using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class ExceptionalPeriodModel
{

    [JsonPropertyName("periodBegin")]
    public DateTimeOffset? PeriodBegin { get; set; }

    [JsonPropertyName("periodEnd")]
    public DateTimeOffset? PeriodEnd { get; set; }

}
