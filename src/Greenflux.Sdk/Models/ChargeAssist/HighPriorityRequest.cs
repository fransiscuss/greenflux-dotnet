#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class HighPriorityRequest
{

    [JsonProperty("chargeSessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeSessionId { get; set; } = default!;

}
