using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class CdrSegment
{

    [JsonPropertyName("segmentId")]
    public int? SegmentId { get; set; }

    [JsonPropertyName("fromUtc")]
    public DateTimeOffset? FromUtc { get; set; }

    [JsonPropertyName("items")]
    [JsonRequired]
    public ICollection<CdrLineItem>? Items { get; set; }

}
