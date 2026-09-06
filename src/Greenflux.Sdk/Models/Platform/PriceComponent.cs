using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class PriceComponent
{
    [JsonPropertyName("type")]
    [JsonRequired]
    public TariffDimensionType Type { get; set; } = default!;

    [JsonPropertyName("price")]
    [JsonRequired]
    public double Price { get; set; } = default!;

    [JsonPropertyName("step_size")]
    [JsonRequired]
    public int StepSize { get; set; } = default!;
}

