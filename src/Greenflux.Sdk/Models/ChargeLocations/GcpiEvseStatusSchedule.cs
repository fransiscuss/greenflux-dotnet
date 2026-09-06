using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiEvseStatusSchedule
{
    [JsonPropertyName("period_begin")]
    public DateTimeOffset? PeriodBegin { get; set; }

    [JsonPropertyName("period_end")]
    public DateTimeOffset? PeriodEnd { get; set; }

    [JsonPropertyName("status")]
    public GcpiEvseStatus? Status { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
}
