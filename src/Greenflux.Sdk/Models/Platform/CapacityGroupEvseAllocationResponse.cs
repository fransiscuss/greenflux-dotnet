#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CapacityGroupEvseAllocationResponse
{
    [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("allocated_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated_amps { get; set; } = default!;

    [JsonProperty("smart_charging_status", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SmartChargingEvseStatus? Smart_charging_status { get; set; } = default!;

    [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EvseLevel? Level { get; set; } = default!;

    [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
    public int? Order { get; set; } = default!;
}

