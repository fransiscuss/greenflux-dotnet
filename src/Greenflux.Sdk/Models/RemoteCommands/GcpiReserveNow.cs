using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiReserveNow
{
    [JsonPropertyName("token")]
    [JsonRequired]
    public GcpiToken Token { get; set; } = new GcpiToken();

    [JsonPropertyName("expiry_date")]
    [JsonRequired]
    public DateTimeOffset ExpiryDate { get; set; } = default!;

    [JsonPropertyName("reservation_id")]
    [JsonRequired]
    public string? ReservationId { get; set; }

    [JsonPropertyName("location_id")]
    [JsonRequired]
    public string? LocationId { get; set; }

    [JsonPropertyName("evse_uid")]
    [JsonRequired]
    public string? EvseUid { get; set; }
}
