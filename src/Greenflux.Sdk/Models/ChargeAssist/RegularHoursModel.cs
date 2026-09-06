using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class RegularHoursModel
{

    [JsonPropertyName("weekday")]
    public int? Weekday { get; set; }

    [JsonPropertyName("periods")]
    public ICollection<RegularHourPeriod>? Periods { get; set; }

}
