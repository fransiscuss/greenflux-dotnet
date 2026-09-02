#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class EvsePriorityChangedResponse
{
    [JsonProperty("capacity_group_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Capacity_group_id { get; set; } = default!;

    [JsonProperty("cpo_external_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_external_id { get; set; } = default!;

    [JsonProperty("evse_uid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Evse_uid { get; set; } = default!;

    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;
}

