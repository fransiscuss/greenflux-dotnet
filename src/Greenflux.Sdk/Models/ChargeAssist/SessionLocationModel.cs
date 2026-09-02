#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class SessionLocationModel
{

    [JsonProperty("coordinates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionLocationCoordinatesModel? Coordinates { get; set; } = default!;

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } = default!;

    [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; } = default!;

    [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; } = default!;

    [JsonProperty("timeZone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZone { get; set; } = default!;

    [JsonProperty("powerType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SessionLocationModelPowerType? PowerType { get; set; } = default!;

    [JsonProperty("branding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionBrandingModel? Branding { get; set; } = default!;

}
