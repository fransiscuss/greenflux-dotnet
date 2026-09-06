using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationSummary
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public LocationSummaryType? Type { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("add")]
    public string? Add { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("lat")]
    public double? Lat { get; set; }

    [JsonPropertyName("lng")]
    public double? Lng { get; set; }

    [JsonPropertyName("conAvail")]
    public int? ConAvail { get; set; }

    [JsonPropertyName("conTot")]
    public int? ConTot { get; set; }

    [JsonPropertyName("dp")]
    public bool? Dp { get; set; }

    [JsonPropertyName("rfid")]
    public bool? Rfid { get; set; }

    [JsonPropertyName("branding")]
    public OperatorBrandingModel? Branding { get; set; }

    [JsonPropertyName("brandingId")]
    public string? BrandingId { get; set; }

    [JsonPropertyName("isHomeCharger")]
    public bool? IsHomeCharger { get; set; }

    [JsonPropertyName("isPrivateLocation")]
    public bool? IsPrivateLocation { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<EvseSummary>? Evses { get; set; }

    [JsonPropertyName("customProperties")]
    public ICollection<CustomPropertyModel>? CustomProperties { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

}
