using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class CdrCostBreakdown
{

    [JsonPropertyName("retailSegments")]
    public ICollection<CdrSegment>? RetailSegments { get; set; }

}
