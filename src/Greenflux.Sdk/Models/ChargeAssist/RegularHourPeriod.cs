using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class RegularHourPeriod
{

    [JsonPropertyName("periodBegin")]
    public string? PeriodBegin { get; set; }

    [JsonPropertyName("periodEnd")]
    public string? PeriodEnd { get; set; }

}
