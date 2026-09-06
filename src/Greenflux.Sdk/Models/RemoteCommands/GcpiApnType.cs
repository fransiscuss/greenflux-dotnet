using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiApnType
{
    [JsonPropertyName("apn")]
    public string? Apn { get; set; }

    [JsonPropertyName("apn_user_name")]
    public string? ApnUserName { get; set; }

    [JsonPropertyName("apn_password")]
    public string? ApnPassword { get; set; }

    [JsonPropertyName("sim_pin")]
    public int? SimPin { get; set; }

    [JsonPropertyName("preferred_network")]
    public string? PreferredNetwork { get; set; }

    [JsonPropertyName("use_only_preferred_network")]
    public bool? UseOnlyPreferredNetwork { get; set; }

    [JsonPropertyName("apn_authentication")]
    public GcpiApnTypeApn_authentication? ApnAuthentication { get; set; }
}
