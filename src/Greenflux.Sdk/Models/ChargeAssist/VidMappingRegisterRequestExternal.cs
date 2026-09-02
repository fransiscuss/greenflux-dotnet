#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class VidMappingRegisterRequestExternal
{

    [JsonProperty("sessionId", Required = Required.AllowNull)]
    public string? SessionId { get; set; } = default!;

}
