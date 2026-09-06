using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class HighPriorityRequest
{

    [JsonPropertyName("chargeSessionId")]
    public string? ChargeSessionId { get; set; }

}
