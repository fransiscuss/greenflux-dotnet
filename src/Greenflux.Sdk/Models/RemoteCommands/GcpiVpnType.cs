#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiVpnType
{
    [JsonProperty("server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Server { get; set; } = default!;

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User { get; set; } = default!;

    [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group { get; set; } = default!;

    [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Password { get; set; } = default!;

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } = default!;
}
