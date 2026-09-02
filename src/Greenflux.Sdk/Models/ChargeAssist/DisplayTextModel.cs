#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class DisplayTextModel
{

    [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Language { get; set; } = default!;

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } = default!;

}
