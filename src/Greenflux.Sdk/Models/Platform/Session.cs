using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Session
{
    [JsonPropertyName("total_cost")]
    public double? TotalCost { get; set; }

    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    [JsonPropertyName("start_datetime")]
    [JsonRequired]
    public DateTimeOffset StartDatetime { get; set; } = default!;

    [JsonPropertyName("end_datetime")]
    public DateTimeOffset? EndDatetime { get; set; }

    [JsonPropertyName("kwh")]
    [JsonRequired]
    public double Kwh { get; set; } = default!;

    [JsonPropertyName("auth_id")]
    [JsonRequired]
    public string AuthId { get; set; } = default!;

    [JsonPropertyName("auth_method")]
    [JsonRequired]
    public AuthMethod AuthMethod { get; set; } = default!;

    [JsonPropertyName("location")]
    [JsonRequired]
    public Location Location { get; set; } = new Location();

    [JsonPropertyName("meter_id")]
    public string? MeterId { get; set; }

    [JsonPropertyName("currency")]
    [JsonRequired]
    public string Currency { get; set; } = default!;

    [JsonPropertyName("charging_periods")]
    public ICollection<ChargingPeriod>? ChargingPeriods { get; set; }

    [JsonPropertyName("status")]
    [JsonRequired]
    public SessionStatus Status { get; set; } = default!;

    [JsonPropertyName("last_updated")]
    [JsonRequired]
    public DateTimeOffset LastUpdated { get; set; } = default!;

    [JsonPropertyName("authorization_id")]
    public string? AuthorizationId { get; set; }

    [JsonPropertyName("vid")]
    public string? Vid { get; set; }

    [JsonPropertyName("state_of_charge")]
    public double? StateOfCharge { get; set; }
}

