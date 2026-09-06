using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class TokenRequest
{
    [JsonPropertyName("uid")]
    [JsonRequired]
    public string Uid { get; set; } = default!;

    [JsonPropertyName("auth_id")]
    [JsonRequired]
    public string AuthId { get; set; } = default!;

    [JsonPropertyName("visual_number")]
    public string? VisualNumber { get; set; }

    [JsonPropertyName("valid")]
    public bool? Valid { get; set; }

    [JsonPropertyName("expiration_date")]
    public DateTimeOffset? ExpirationDate { get; set; }

    [JsonPropertyName("roaming_allowed")]
    public bool? RoamingAllowed { get; set; }

    [JsonPropertyName("whitelist_type")]
    public TokenRequestWhitelist_type? WhitelistType { get; set; }

    [JsonPropertyName("driver_id")]
    [JsonRequired]
    public string DriverId { get; set; } = default!;

    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; set; }

    [JsonPropertyName("modified_on_utc")]
    [JsonRequired]
    public DateTimeOffset ModifiedOnUtc { get; set; } = default!;

    [JsonPropertyName("modified_by")]
    [JsonRequired]
    public string ModifiedBy { get; set; } = default!;
}

