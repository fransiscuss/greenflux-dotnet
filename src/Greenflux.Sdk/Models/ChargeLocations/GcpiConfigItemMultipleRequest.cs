using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiConfigItemMultipleRequest
{
    [JsonPropertyName("charge_station_ids")]
    public ICollection<string>? ChargeStationIds { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("keys")]
    public ICollection<string>? Keys { get; set; }

    [JsonPropertyName("firmware_version")]
    public string? FirmwareVersion { get; set; }

    [JsonPropertyName("charge_point_vendor")]
    public string? ChargePointVendor { get; set; }

    [JsonPropertyName("protocol_version")]
    public string? ProtocolVersion { get; set; }

    [JsonPropertyName("limit")]
    [JsonRequired]
    public int Limit { get; set; } = default!;

    [JsonPropertyName("offset")]
    [JsonRequired]
    public int Offset { get; set; } = default!;
}
