#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class CreateAppTokenRequest
{

    [JsonProperty("appToken", Required = Required.Always)]
    public string AppToken { get; set; } = default!;

    [JsonProperty("driverId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DriverId { get; set; } = default!;

    [JsonProperty("emspId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmspId { get; set; } = default!;

}
