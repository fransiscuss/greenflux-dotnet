#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class ChargingPeriod
{
    [JsonProperty("start_date_time", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date_time { get; set; } = default!;

    [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CdrDimension>? Dimensions { get; set; } = default!;
}

