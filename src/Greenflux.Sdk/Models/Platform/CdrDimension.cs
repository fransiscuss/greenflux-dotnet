#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CdrDimension
{
    [JsonProperty("type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CdrDimensionType Type { get; set; } = default!;

    [JsonProperty("volume", Required = Required.Always)]
    public double Volume { get; set; } = default!;
}

