using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>List of EVSEs that belong to this Location.</summary>
public partial class GcpiEvse
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("evse_id")]
    public string? EvseId { get; set; }

    [JsonPropertyName("status")]
    public GcpiEvseStatus? Status { get; set; }

    [JsonPropertyName("status_schedule")]
    public ICollection<GcpiEvseStatusSchedule>? StatusSchedule { get; set; }

    [JsonPropertyName("capabilities")]
    public ICollection<string>? Capabilities { get; set; }

    [JsonPropertyName("connectors")]
    public ICollection<GcpiConnector>? Connectors { get; set; }

    [JsonPropertyName("floor_level")]
    public string? FloorLevel { get; set; }

    [JsonPropertyName("coordinates")]
    public GcpiGeoLocation? Coordinates { get; set; }

    [JsonPropertyName("physical_reference")]
    public string? PhysicalReference { get; set; }

    [JsonPropertyName("directions")]
    public ICollection<GcpiDisplayText>? Directions { get; set; }

    [JsonPropertyName("parking_restrictions")]
    public ICollection<GcpiParkingRestriction>? ParkingRestrictions { get; set; }

    [JsonPropertyName("images")]
    public ICollection<GcpiImage>? Images { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTimeOffset? LastUpdated { get; set; }

    [JsonPropertyName("evse_sequence_number")]
    public int? EvseSequenceNumber { get; set; }
}
