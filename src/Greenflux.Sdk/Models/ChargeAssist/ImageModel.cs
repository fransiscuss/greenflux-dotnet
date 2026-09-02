#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class ImageModel
{

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } = default!;

    [JsonProperty("thumbnail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thumbnail { get; set; } = default!;

    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ImageModelCategory? Category { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } = default!;

    [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; } = default!;

    [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Height { get; set; } = default!;

}
