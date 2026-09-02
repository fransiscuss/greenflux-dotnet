#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.RemoteCommands;

public partial class GcpiToken
{
    [JsonProperty("uid", Required = Required.AllowNull)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiTokenType? Type { get; set; } = default!;

    [JsonProperty("auth_id", Required = Required.AllowNull)]
    public string? Auth_id { get; set; } = default!;

    [JsonProperty("visual_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Visual_number { get; set; } = default!;

    [JsonProperty("issuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Issuer { get; set; } = default!;

    [JsonProperty("valid", Required = Required.Always)]
    public bool Valid { get; set; } = default!;

    [JsonProperty("whitelist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiWhitelistType? Whitelist { get; set; } = default!;

    [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Language { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_updated { get; set; } = default!;
}
