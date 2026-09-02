#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiImage
{
    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } = default!;

    [JsonProperty("thumbnail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thumbnail { get; set; } = default!;

    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiImageCategory? Category { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } = default!;

    [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; } = default!;

    [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Height { get; set; } = default!;
}
