using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Location
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    [JsonPropertyName("type")]
    [JsonRequired]
    public LocationType Type { get; set; } = default!;

    [JsonPropertyName("access_type")]
    public AccessType? AccessType { get; set; }

    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    [JsonRequired]
    public string Address { get; set; } = default!;

    [JsonPropertyName("city")]
    [JsonRequired]
    public string City { get; set; } = default!;

    [JsonPropertyName("postal_code")]
    [JsonRequired]
    public string PostalCode { get; set; } = default!;

    [JsonPropertyName("country")]
    [JsonRequired]
    public string Country { get; set; } = default!;

    [JsonPropertyName("coordinates")]
    [JsonRequired]
    public GeoLocation Coordinates { get; set; } = new GeoLocation();

    [JsonPropertyName("related_locations")]
    public ICollection<AdditionalGeoLocation>? RelatedLocations { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<Evse>? Evses { get; set; }

    [JsonPropertyName("directions")]
    public ICollection<DisplayText>? Directions { get; set; }

    [JsonPropertyName("operator")]
    public BusinessDetails? Operator { get; set; }

    [JsonPropertyName("suboperator")]
    public BusinessDetails? Suboperator { get; set; }

    [JsonPropertyName("auth_rules")]
    public ICollection<AuthRule>? AuthRules { get; set; }

    [JsonPropertyName("owner")]
    public BusinessDetails? Owner { get; set; }

    [JsonPropertyName("facilities")]
    public ICollection<Facility>? Facilities { get; set; }

    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("opening_times")]
    public Hours? OpeningTimes { get; set; }

    [JsonPropertyName("charging_when_closed")]
    public bool? ChargingWhenClosed { get; set; }

    [JsonPropertyName("images")]
    public ICollection<Image>? Images { get; set; }

    [JsonPropertyName("energy_mix")]
    public EnergyMix? EnergyMix { get; set; }

    [JsonPropertyName("last_updated")]
    [JsonRequired]
    public DateTimeOffset LastUpdated { get; set; } = default!;
}

