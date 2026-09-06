using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class ExceptionalPeriod
{
    [JsonPropertyName("period_begin")]
    [JsonRequired]
    public DateTimeOffset PeriodBegin { get; set; } = default!;

    [JsonPropertyName("period_end")]
    [JsonRequired]
    public DateTimeOffset PeriodEnd { get; set; } = default!;
}

