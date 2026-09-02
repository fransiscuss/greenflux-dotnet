#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.RemoteCommands;

public partial class GcpiInstallCertificate
{
    [JsonProperty("charge_station_id", Required = Required.Always)]
    public string Charge_station_id { get; set; } = default!;

    [JsonProperty("certificateType", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiInstallCertificateEnumType CertificateType { get; set; } = default!;

    [JsonProperty("certificate", Required = Required.Always)]
    public string Certificate { get; set; } = default!;
}
