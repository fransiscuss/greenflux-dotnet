#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

/// <summary>List of EVSEs that belong to this Location.</summary>
public partial class GcpiEvse
{
    [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("evse_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Evse_id { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiEvseStatus? Status { get; set; } = default!;

    [JsonProperty("status_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiEvseStatusSchedule>? Status_schedule { get; set; } = default!;

    [JsonProperty("capabilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Capabilities { get; set; } = default!;

    [JsonProperty("connectors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiConnector>? Connectors { get; set; } = default!;

    [JsonProperty("floor_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Floor_level { get; set; } = default!;

    [JsonProperty("coordinates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiGeoLocation? Coordinates { get; set; } = default!;

    [JsonProperty("physical_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Physical_reference { get; set; } = default!;

    [JsonProperty("directions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiDisplayText>? Directions { get; set; } = default!;

    [JsonProperty("parking_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<GcpiParkingRestriction>? Parking_restrictions { get; set; } = default!;

    [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiImage>? Images { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_updated { get; set; } = default!;

    [JsonProperty("evse_sequence_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Evse_sequence_number { get; set; } = default!;
}
