#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class EvseModel
{

    [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EvseModelStatus? Status { get; set; } = default!;

    [JsonProperty("capabilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<Capabilities>? Capabilities { get; set; } = default!;

    [JsonProperty("connectors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ConnectorModel>? Connectors { get; set; } = default!;

    [JsonProperty("floorLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FloorLevel { get; set; } = default!;

    [JsonProperty("coordinates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GeoLocationModel>? Coordinates { get; set; } = default!;

    [JsonProperty("physicalReference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhysicalReference { get; set; } = default!;

    [JsonProperty("chargingNotAllowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ChargingNotAllowed { get; set; } = default!;

    [JsonProperty("agreement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agreement { get; set; } = default!;

    [JsonProperty("directions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DisplayTextModel>? Directions { get; set; } = default!;

    [JsonProperty("parkingRestrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<ParkingRestrictions>? ParkingRestrictions { get; set; } = default!;

    [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ImageModel>? Images { get; set; } = default!;

    [JsonProperty("matchesFilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchesFilter { get; set; } = default!;

    [JsonProperty("restrictedAccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RestrictedAccess { get; set; } = default!;

    [JsonProperty("remoteCommandsCapable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemoteCommandsCapable { get; set; } = default!;

    [JsonProperty("chargerType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargerType { get; set; } = default!;

    [JsonProperty("isPrivateCharger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPrivateCharger { get; set; } = default!;

    [JsonProperty("evseId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseId { get; set; } = default!;

    [JsonProperty("isQrPresent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsQrPresent { get; set; } = default!;

    [JsonProperty("lastUpdated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdated { get; set; } = default!;

}
