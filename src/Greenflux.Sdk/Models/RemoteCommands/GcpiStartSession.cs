using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiStartSession
{
    [JsonPropertyName("token")]
    [JsonRequired]
    public GcpiToken Token { get; set; } = new GcpiToken();

    [JsonPropertyName("location_id")]
    [JsonRequired]
    public string LocationId { get; set; } = default!;

    [JsonPropertyName("evse_uid")]
    [JsonRequired]
    public string EvseUid { get; set; } = default!;

    [JsonPropertyName("connector_id")]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("chargestation_id")]
    [JsonRequired]
    public string ChargestationId { get; set; } = default!;
}
