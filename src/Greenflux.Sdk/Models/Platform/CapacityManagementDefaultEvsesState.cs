#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CapacityManagementDefaultEvsesState
{
    [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
    public int? Number { get; set; } = default!;

    [JsonProperty("allocated", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated { get; set; } = default!;

    [JsonProperty("allocated_l1", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated_l1 { get; set; } = default!;

    [JsonProperty("allocated_l2", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated_l2 { get; set; } = default!;

    [JsonProperty("allocated_l3", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated_l3 { get; set; } = default!;

    [JsonProperty("power_consumption_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Power_consumption_watts { get; set; } = default!;

    [JsonProperty("power_consumption_l1_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Power_consumption_l1_watts { get; set; } = default!;

    [JsonProperty("power_consumption_l2_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Power_consumption_l2_watts { get; set; } = default!;

    [JsonProperty("power_consumption_l3_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Power_consumption_l3_watts { get; set; } = default!;
}

