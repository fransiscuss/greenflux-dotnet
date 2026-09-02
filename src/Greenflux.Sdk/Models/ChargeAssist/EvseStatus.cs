#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class EvseStatus
{

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } = default!;

    [JsonProperty("evseId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseId { get; set; } = default!;

    [JsonProperty("parkingRestrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<ParkingRestrictions2>? ParkingRestrictions { get; set; } = default!;

    [JsonProperty("restrictedAccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RestrictedAccess { get; set; } = default!;

    [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("lu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lu { get; set; } = default!;

}
