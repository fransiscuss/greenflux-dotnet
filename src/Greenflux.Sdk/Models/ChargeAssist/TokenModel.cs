using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TokenModel
{

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("shareableId")]
    public string? ShareableId { get; set; }

    [JsonPropertyName("authId")]
    public string? AuthId { get; set; }

    [JsonPropertyName("groups")]
    public ICollection<string>? Groups { get; set; }

    [JsonPropertyName("groupFilterString")]
    public string? GroupFilterString { get; set; }

    [JsonPropertyName("alerts")]
    public ICollection<LocationAlertModel>? Alerts { get; set; }

    [JsonPropertyName("vidMapping")]
    public VidMappingModel? VidMapping { get; set; }

    [JsonPropertyName("settings")]
    public TokenSettingsModel? Settings { get; set; }

    [JsonPropertyName("vidUpdating")]
    public bool? VidUpdating { get; set; }

    [JsonPropertyName("muteVidNotifications")]
    public bool? MuteVidNotifications { get; set; }

    [JsonPropertyName("personalChargerSettings")]
    public ICollection<PersonalChargerSettingsModel>? PersonalChargerSettings { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("subscriptionSettings")]
    public ApiSubscriptionSettingsModel? SubscriptionSettings { get; set; }

}
