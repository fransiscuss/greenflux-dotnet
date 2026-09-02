#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CapacityGroupCapacityManagementDcStateRequest
{
    [JsonProperty("default_group_capacity_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Default_group_capacity_watts { get; set; } = default!;
}

