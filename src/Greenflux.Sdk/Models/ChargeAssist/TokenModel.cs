#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TokenModel
{

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("shareableId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ShareableId { get; set; } = default!;

    [JsonProperty("authId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuthId { get; set; } = default!;

    [JsonProperty("groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Groups { get; set; } = default!;

    [JsonProperty("groupFilterString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupFilterString { get; set; } = default!;

    [JsonProperty("alerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LocationAlertModel>? Alerts { get; set; } = default!;

    [JsonProperty("vidMapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public VidMappingModel? VidMapping { get; set; } = default!;

    [JsonProperty("settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TokenSettingsModel? Settings { get; set; } = default!;

    [JsonProperty("vidUpdating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? VidUpdating { get; set; } = default!;

    [JsonProperty("muteVidNotifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MuteVidNotifications { get; set; } = default!;

    [JsonProperty("personalChargerSettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PersonalChargerSettingsModel>? PersonalChargerSettings { get; set; } = default!;

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } = default!;

    [JsonProperty("subscriptionSettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ApiSubscriptionSettingsModel? SubscriptionSettings { get; set; } = default!;

}
