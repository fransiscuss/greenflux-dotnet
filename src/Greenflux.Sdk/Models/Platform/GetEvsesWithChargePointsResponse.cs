#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class GetEvsesWithChargePointsResponse
{
    [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("charge_point", NullValueHandling = NullValueHandling.Ignore)]
    public EvseChangePointModel? Charge_point { get; set; } = default!;
}

