#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class Token
{
    [JsonProperty("uid", Required = Required.Always)]
    public string Uid { get; set; } = default!;

    [JsonProperty("auth_id", Required = Required.Always)]
    public string Auth_id { get; set; } = default!;

    [JsonProperty("visual_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Visual_number { get; set; } = default!;

    [JsonProperty("valid", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Valid { get; set; } = default!;

    [JsonProperty("expiration_date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Expiration_date { get; set; } = default!;

    [JsonProperty("roaming_allowed", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Roaming_allowed { get; set; } = default!;

    [JsonProperty("whitelist_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public WhitelistType? Whitelist_type { get; set; } = default!;

    [JsonProperty("driver_id", Required = Required.Always)]
    public string Driver_id { get; set; } = default!;

    [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer_id { get; set; } = default!;

    [JsonProperty("modified_on_utc", Required = Required.Always)]
    public DateTimeOffset Modified_on_utc { get; set; } = default!;

    [JsonProperty("modified_by", Required = Required.Always)]
    public string Modified_by { get; set; } = default!;
}

