using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class RegularHours
{
    [JsonPropertyName("weekday")]
    [JsonRequired]
    public int Weekday { get; set; } = default!;

    [JsonPropertyName("period_begin")]
    [JsonRequired]
    public string PeriodBegin { get; set; } = default!;

    [JsonPropertyName("period_end")]
    [JsonRequired]
    public string PeriodEnd { get; set; } = default!;
}

