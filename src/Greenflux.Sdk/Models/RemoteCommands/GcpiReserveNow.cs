#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiReserveNow
{
    [JsonProperty("token", Required = Required.Always)]
    public GcpiToken Token { get; set; } = new GcpiToken();

    [JsonProperty("expiry_date", Required = Required.Always)]
    public DateTimeOffset Expiry_date { get; set; } = default!;

    [JsonProperty("reservation_id", Required = Required.AllowNull)]
    public string? Reservation_id { get; set; } = default!;

    [JsonProperty("location_id", Required = Required.AllowNull)]
    public string? Location_id { get; set; } = default!;

    [JsonProperty("evse_uid", Required = Required.AllowNull)]
    public string? Evse_uid { get; set; } = default!;
}
