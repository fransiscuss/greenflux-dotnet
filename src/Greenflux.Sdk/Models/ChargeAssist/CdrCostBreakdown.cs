#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class CdrCostBreakdown
{

    [JsonProperty("retailSegments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CdrSegment>? RetailSegments { get; set; } = default!;

}
