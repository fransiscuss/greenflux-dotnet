using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class EvseStatus
{

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("evseId")]
    public string? EvseId { get; set; }

    [JsonPropertyName("parkingRestrictions")]
    public ICollection<ParkingRestrictions2>? ParkingRestrictions { get; set; }

    [JsonPropertyName("restrictedAccess")]
    public bool? RestrictedAccess { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("lu")]
    public DateTimeOffset? Lu { get; set; }

}
