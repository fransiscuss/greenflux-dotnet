#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class Evse
{
    [JsonProperty("uid", Required = Required.Always)]
    public string Uid { get; set; } = default!;

    [JsonProperty("evse_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Evse_id { get; set; } = default!;

    [JsonProperty("status", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public Status Status { get; set; } = default!;

    [JsonProperty("status_schedule", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StatusSchedule>? Status_schedule { get; set; } = default!;

    [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<Capability>? Capabilities { get; set; } = default!;

    [JsonProperty("connectors", Required = Required.Always)]
    public ICollection<Connector> Connectors { get; set; } = new Collection<Connector>();

    [JsonProperty("floor_level", NullValueHandling = NullValueHandling.Ignore)]
    public string? Floor_level { get; set; } = default!;

    [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
    public GeoLocation? Coordinates { get; set; } = default!;

    [JsonProperty("physical_reference", NullValueHandling = NullValueHandling.Ignore)]
    public string? Physical_reference { get; set; } = default!;

    [JsonProperty("directions", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DisplayText>? Directions { get; set; } = default!;

    [JsonProperty("parking_restrictions", NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<ParkingRestriction>? Parking_restrictions { get; set; } = default!;

    [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Image>? Images { get; set; } = default!;

    [JsonProperty("charging_behavior", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ChargingBehavior? Charging_behavior { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Always)]
    public DateTimeOffset Last_updated { get; set; } = default!;
}

