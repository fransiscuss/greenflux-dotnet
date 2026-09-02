#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class GetTokensEntry
{
    [JsonProperty("state", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GetTokensEntryState State { get; set; } = default!;

    [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } = default!;

    [JsonProperty("auth_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Auth_id { get; set; } = default!;

    [JsonProperty("visual_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Visual_number { get; set; } = default!;

    [JsonProperty("scopes", NullValueHandling = NullValueHandling.Ignore)]
    public GetTokensEntryScopes? Scopes { get; set; } = default!;
}

