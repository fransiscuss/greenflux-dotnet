using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class ReplaceEvsesWithChargePointsRequest
{
    [JsonPropertyName("uid")]
    [JsonRequired]
    public string Uid { get; set; } = default!;
}

