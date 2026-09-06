using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiInstallCertificate
{
    [JsonPropertyName("charge_station_id")]
    [JsonRequired]
    public string ChargeStationId { get; set; } = default!;

    [JsonPropertyName("certificateType")]
    [JsonRequired]
    public GcpiInstallCertificateEnumType CertificateType { get; set; } = default!;

    [JsonPropertyName("certificate")]
    [JsonRequired]
    public string Certificate { get; set; } = default!;
}
