using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class StopRequest
{

    [JsonPropertyName("chargeSessionId")]
    [JsonRequired]
    public string ChargeSessionId { get; set; } = default!;

}
