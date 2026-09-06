using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class EvseModel
{

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("status")]
    public EvseModelStatus? Status { get; set; }

    [JsonPropertyName("capabilities")]
    public ICollection<Capabilities>? Capabilities { get; set; }

    [JsonPropertyName("connectors")]
    public ICollection<ConnectorModel>? Connectors { get; set; }

    [JsonPropertyName("floorLevel")]
    public string? FloorLevel { get; set; }

    [JsonPropertyName("coordinates")]
    public ICollection<GeoLocationModel>? Coordinates { get; set; }

    [JsonPropertyName("physicalReference")]
    public string? PhysicalReference { get; set; }

    [JsonPropertyName("chargingNotAllowed")]
    public bool? ChargingNotAllowed { get; set; }

    [JsonPropertyName("agreement")]
    public bool? Agreement { get; set; }

    [JsonPropertyName("directions")]
    public ICollection<DisplayTextModel>? Directions { get; set; }

    [JsonPropertyName("parkingRestrictions")]
    public ICollection<ParkingRestrictions>? ParkingRestrictions { get; set; }

    [JsonPropertyName("images")]
    public ICollection<ImageModel>? Images { get; set; }

    [JsonPropertyName("matchesFilter")]
    public bool? MatchesFilter { get; set; }

    [JsonPropertyName("restrictedAccess")]
    public bool? RestrictedAccess { get; set; }

    [JsonPropertyName("remoteCommandsCapable")]
    public bool? RemoteCommandsCapable { get; set; }

    [JsonPropertyName("chargerType")]
    public string? ChargerType { get; set; }

    [JsonPropertyName("isPrivateCharger")]
    public bool? IsPrivateCharger { get; set; }

    [JsonPropertyName("evseId")]
    public string? EvseId { get; set; }

    [JsonPropertyName("isQrPresent")]
    public bool? IsQrPresent { get; set; }

    [JsonPropertyName("lastUpdated")]
    public DateTimeOffset? LastUpdated { get; set; }

}
