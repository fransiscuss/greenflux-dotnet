#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class EvseDetailsResponse
{
    [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("capacity_group_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Capacity_group_id { get; set; } = default!;

    [JsonProperty("charge_point_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_point_id { get; set; } = default!;

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EvseStatus? Status { get; set; } = default!;

    [JsonProperty("smart_charging_status", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SmartChargingEvseStatus? Smart_charging_status { get; set; } = default!;

    [JsonProperty("connectors", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Connectors { get; set; } = default!;
}

