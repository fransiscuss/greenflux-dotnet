#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationSummary
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationSummaryType? Type { get; set; } = default!;

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

    [JsonProperty("add", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Add { get; set; } = default!;

    [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; } = default!;

    [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; } = default!;

    [JsonProperty("lat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Lat { get; set; } = default!;

    [JsonProperty("lng", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Lng { get; set; } = default!;

    [JsonProperty("conAvail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConAvail { get; set; } = default!;

    [JsonProperty("conTot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConTot { get; set; } = default!;

    [JsonProperty("dp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dp { get; set; } = default!;

    [JsonProperty("rfid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Rfid { get; set; } = default!;

    [JsonProperty("branding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public OperatorBrandingModel? Branding { get; set; } = default!;

    [JsonProperty("brandingId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BrandingId { get; set; } = default!;

    [JsonProperty("isHomeCharger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsHomeCharger { get; set; } = default!;

    [JsonProperty("isPrivateLocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPrivateLocation { get; set; } = default!;

    [JsonProperty("evses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EvseSummary>? Evses { get; set; } = default!;

    [JsonProperty("customProperties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomPropertyModel>? CustomProperties { get; set; } = default!;

    [JsonProperty("timeZone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZone { get; set; } = default!;

}
