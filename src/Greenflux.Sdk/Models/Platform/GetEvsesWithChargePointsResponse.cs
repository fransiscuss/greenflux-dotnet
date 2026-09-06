using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class GetEvsesWithChargePointsResponse
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("charge_point")]
    public EvseChangePointModel? ChargePoint { get; set; }
}

