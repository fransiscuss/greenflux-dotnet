using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiNetworkConnectionProfile
{
    [JsonPropertyName("ocpp_version")]
    [JsonRequired]
    public GcpiNetworkConnectionProfileOcpp_version OcppVersion { get; set; } = default!;

    [JsonPropertyName("ocpp_transport")]
    [JsonRequired]
    public GcpiNetworkConnectionProfileOcpp_transport OcppTransport { get; set; } = default!;

    [JsonPropertyName("ocpp_csms_url")]
    [JsonRequired]
    public string OcppCsmsUrl { get; set; } = default!;

    [JsonPropertyName("message_timeout")]
    [JsonRequired]
    public int MessageTimeout { get; set; } = default!;

    [JsonPropertyName("security_profile")]
    [JsonRequired]
    public int SecurityProfile { get; set; } = default!;

    [JsonPropertyName("ocpp_interface")]
    [JsonRequired]
    public GcpiNetworkConnectionProfileOcpp_interface OcppInterface { get; set; } = default!;

    [JsonPropertyName("vpn")]
    public GcpiVpnType? Vpn { get; set; }

    [JsonPropertyName("apn")]
    public GcpiApnType? Apn { get; set; }

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
