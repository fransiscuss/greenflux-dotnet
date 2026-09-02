#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationSummaryGeoListResponse
{

    [JsonProperty("boundingBox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public BoundingBox? BoundingBox { get; set; } = default!;

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LocationSummary>? Data { get; set; } = default!;

    [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MetaInfo? Meta { get; set; } = default!;

}
