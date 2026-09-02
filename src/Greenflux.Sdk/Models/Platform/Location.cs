#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class Location
{
    [JsonProperty("id", Required = Required.Always)]
    public string Id { get; set; } = default!;

    [JsonProperty("type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationType Type { get; set; } = default!;

    [JsonProperty("access_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public AccessType? Access_type { get; set; } = default!;

    [JsonProperty("publish", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Publish { get; set; } = default!;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("address", Required = Required.Always)]
    public string Address { get; set; } = default!;

    [JsonProperty("city", Required = Required.Always)]
    public string City { get; set; } = default!;

    [JsonProperty("postal_code", Required = Required.Always)]
    public string Postal_code { get; set; } = default!;

    [JsonProperty("country", Required = Required.Always)]
    public string Country { get; set; } = default!;

    [JsonProperty("coordinates", Required = Required.Always)]
    public GeoLocation Coordinates { get; set; } = new GeoLocation();

    [JsonProperty("related_locations", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AdditionalGeoLocation>? Related_locations { get; set; } = default!;

    [JsonProperty("evses", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Evse>? Evses { get; set; } = default!;

    [JsonProperty("directions", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DisplayText>? Directions { get; set; } = default!;

    [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
    public BusinessDetails? Operator { get; set; } = default!;

    [JsonProperty("suboperator", NullValueHandling = NullValueHandling.Ignore)]
    public BusinessDetails? Suboperator { get; set; } = default!;

    [JsonProperty("auth_rules", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AuthRule>? Auth_rules { get; set; } = default!;

    [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
    public BusinessDetails? Owner { get; set; } = default!;

    [JsonProperty("facilities", NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<Facility>? Facilities { get; set; } = default!;

    [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
    public string? Time_zone { get; set; } = default!;

    [JsonProperty("opening_times", NullValueHandling = NullValueHandling.Ignore)]
    public Hours? Opening_times { get; set; } = default!;

    [JsonProperty("charging_when_closed", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Charging_when_closed { get; set; } = default!;

    [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Image>? Images { get; set; } = default!;

    [JsonProperty("energy_mix", NullValueHandling = NullValueHandling.Ignore)]
    public EnergyMix? Energy_mix { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Always)]
    public DateTimeOffset Last_updated { get; set; } = default!;
}

