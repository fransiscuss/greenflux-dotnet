#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class StopRequest
{

    [JsonProperty("chargeSessionId", Required = Required.Always)]
    public string ChargeSessionId { get; set; } = default!;

}
