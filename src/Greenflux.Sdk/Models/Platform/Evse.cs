using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class Evse
{
    [JsonPropertyName("uid")]
    [JsonRequired]
    public string Uid { get; set; } = default!;

    [JsonPropertyName("evse_id")]
    public string? EvseId { get; set; }

    [JsonPropertyName("status")]
    [JsonRequired]
    public Status Status { get; set; } = default!;

    [JsonPropertyName("status_schedule")]
    public ICollection<StatusSchedule>? StatusSchedule { get; set; }

    [JsonPropertyName("capabilities")]
    public ICollection<Capability>? Capabilities { get; set; }

    [JsonPropertyName("connectors")]
    [JsonRequired]
    public ICollection<Connector> Connectors { get; set; } = new Collection<Connector>();

    [JsonPropertyName("floor_level")]
    public string? FloorLevel { get; set; }

    [JsonPropertyName("coordinates")]
    public GeoLocation? Coordinates { get; set; }

    [JsonPropertyName("physical_reference")]
    public string? PhysicalReference { get; set; }

    [JsonPropertyName("directions")]
    public ICollection<DisplayText>? Directions { get; set; }

    [JsonPropertyName("parking_restrictions")]
    public ICollection<ParkingRestriction>? ParkingRestrictions { get; set; }

    [JsonPropertyName("images")]
    public ICollection<Image>? Images { get; set; }

    [JsonPropertyName("charging_behavior")]
    public ChargingBehavior? ChargingBehavior { get; set; }

    [JsonPropertyName("last_updated")]
    [JsonRequired]
    public DateTimeOffset LastUpdated { get; set; } = default!;
}

