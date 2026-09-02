#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.RemoteCommands;

public partial class GcpiNetworkConnectionProfile
{
    [JsonProperty("ocpp_version", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiNetworkConnectionProfileOcpp_version Ocpp_version { get; set; } = default!;

    [JsonProperty("ocpp_transport", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiNetworkConnectionProfileOcpp_transport Ocpp_transport { get; set; } = default!;

    [JsonProperty("ocpp_csms_url", Required = Required.Always)]
    public string Ocpp_csms_url { get; set; } = default!;

    [JsonProperty("message_timeout", Required = Required.Always)]
    public int Message_timeout { get; set; } = default!;

    [JsonProperty("security_profile", Required = Required.Always)]
    public int Security_profile { get; set; } = default!;

    [JsonProperty("ocpp_interface", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiNetworkConnectionProfileOcpp_interface Ocpp_interface { get; set; } = default!;

    [JsonProperty("vpn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiVpnType? Vpn { get; set; } = default!;

    [JsonProperty("apn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiApnType? Apn { get; set; } = default!;

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
