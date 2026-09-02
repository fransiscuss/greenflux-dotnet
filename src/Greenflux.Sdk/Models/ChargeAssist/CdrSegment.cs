#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class CdrSegment
{

    [JsonProperty("segmentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SegmentId { get; set; } = default!;

    [JsonProperty("fromUtc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? FromUtc { get; set; } = default!;

    [JsonProperty("items", Required = Required.AllowNull)]
    public ICollection<CdrLineItem>? Items { get; set; } = default!;

}
