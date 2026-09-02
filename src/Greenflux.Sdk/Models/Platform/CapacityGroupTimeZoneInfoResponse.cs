#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CapacityGroupTimeZoneInfoResponse
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Display_name { get; set; } = default!;

    [JsonProperty("utc_offset", NullValueHandling = NullValueHandling.Ignore)]
    public string? Utc_offset { get; set; } = default!;

    [JsonProperty("supports_daylight_saving_time", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Supports_daylight_saving_time { get; set; } = default!;
}

