using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class CreateAppTokenRequest
{

    [JsonPropertyName("appToken")]
    [JsonRequired]
    public string AppToken { get; set; } = default!;

    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    [JsonPropertyName("emspId")]
    public string? EmspId { get; set; }

}
