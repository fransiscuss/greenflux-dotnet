#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class Image
{
    [JsonProperty("url", Required = Required.Always)]
    public string Url { get; set; } = default!;

    [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
    public string? Thumbnail { get; set; } = default!;

    [JsonProperty("category", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ImageCategory Category { get; set; } = default!;

    [JsonProperty("type", Required = Required.Always)]
    public string Type { get; set; } = default!;

    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; } = default!;

    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    public int? Height { get; set; } = default!;
}

