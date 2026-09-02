#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.RemoteCommands;

public partial class GcpiApnType
{
    [JsonProperty("apn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apn { get; set; } = default!;

    [JsonProperty("apn_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apn_user_name { get; set; } = default!;

    [JsonProperty("apn_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apn_password { get; set; } = default!;

    [JsonProperty("sim_pin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sim_pin { get; set; } = default!;

    [JsonProperty("preferred_network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Preferred_network { get; set; } = default!;

    [JsonProperty("use_only_preferred_network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_only_preferred_network { get; set; } = default!;

    [JsonProperty("apn_authentication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiApnTypeApn_authentication? Apn_authentication { get; set; } = default!;
}
