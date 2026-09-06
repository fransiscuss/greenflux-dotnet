using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupTimeZoneInfoResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("utc_offset")]
    public string? UtcOffset { get; set; }

    [JsonPropertyName("supports_daylight_saving_time")]
    public bool? SupportsDaylightSavingTime { get; set; }
}

