#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class DisplayText
{
    [JsonProperty("language", Required = Required.AllowNull)]
    public string? Language { get; set; } = default!;

    [JsonProperty("text", Required = Required.Always)]
    public string Text { get; set; } = default!;
}

