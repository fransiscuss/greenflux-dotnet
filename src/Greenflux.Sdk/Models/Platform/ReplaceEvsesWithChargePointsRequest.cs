#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class ReplaceEvsesWithChargePointsRequest
{
    [JsonProperty("uid", Required = Required.Always)]
    public string Uid { get; set; } = default!;
}

