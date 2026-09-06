using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiCancelReservation
{
    [JsonPropertyName("reservation_id")]
    public string? ReservationId { get; set; }
}
