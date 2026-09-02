#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CapacityManagementDcEvsesState
{
    [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
    public int? Number { get; set; } = default!;

    [JsonProperty("allocated", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated { get; set; } = default!;

    [JsonProperty("power_consumption_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Power_consumption_watts { get; set; } = default!;
}

