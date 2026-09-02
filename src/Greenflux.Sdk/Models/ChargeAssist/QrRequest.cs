#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class QrRequest
{

    [JsonProperty("url", Required = Required.Always)]
    public string Url { get; set; } = default!;

}
