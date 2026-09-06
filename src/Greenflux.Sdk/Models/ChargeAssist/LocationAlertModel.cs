using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class LocationAlertModel
{

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("expirationTime")]
    public DateTimeOffset? ExpirationTime { get; set; }

}
