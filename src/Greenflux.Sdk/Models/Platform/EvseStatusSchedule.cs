using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class EvseStatusSchedule
{
    [JsonPropertyName("period_begin")]
    [JsonRequired]
    public DateTimeOffset PeriodBegin { get; set; } = default!;

    [JsonPropertyName("period_end")]
    public DateTimeOffset? PeriodEnd { get; set; }

    [JsonPropertyName("status")]
    [JsonRequired]
    public EvseStatus Status { get; set; } = default!;

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
}

