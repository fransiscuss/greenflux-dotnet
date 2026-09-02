#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class SessionMileageRequest
{

    [JsonProperty("chargeSessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeSessionId { get; set; } = default!;

    [JsonProperty("mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mileage { get; set; } = default!;

}
