using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SessionMileageRequest
{

    [JsonPropertyName("chargeSessionId")]
    public string? ChargeSessionId { get; set; }

    [JsonPropertyName("mileage")]
    public string? Mileage { get; set; }

}
