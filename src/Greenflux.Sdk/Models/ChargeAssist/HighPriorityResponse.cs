using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class HighPriorityResponse
{

    [JsonPropertyName("status")]
    public HighPriorityResponseStatus? Status { get; set; }

}
