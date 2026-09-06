using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class ChargingPeriod
{
    [JsonPropertyName("start_date_time")]
    public DateTimeOffset? StartDateTime { get; set; }

    [JsonPropertyName("dimensions")]
    public ICollection<CdrDimension>? Dimensions { get; set; }
}

