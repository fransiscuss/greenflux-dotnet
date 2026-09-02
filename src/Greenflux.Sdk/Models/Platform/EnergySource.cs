#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class EnergySource
{
    [JsonProperty("source", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EnergySourceCategory Source { get; set; } = default!;

    [JsonProperty("percentage", Required = Required.AllowNull)]
    public double? Percentage { get; set; } = default!;
}

