#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CapacityGroupEvseAllocationResponseDceda
{
    [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("allocated_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated_watts { get; set; } = default!;

    [JsonProperty("smart_charging_status", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SmartChargingEvseStatus? Smart_charging_status { get; set; } = default!;
}

