#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class PriceComponent
{
    [JsonProperty("type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public TariffDimensionType Type { get; set; } = default!;

    [JsonProperty("price", Required = Required.Always)]
    public double Price { get; set; } = default!;

    [JsonProperty("step_size", Required = Required.Always)]
    public int Step_size { get; set; } = default!;
}

