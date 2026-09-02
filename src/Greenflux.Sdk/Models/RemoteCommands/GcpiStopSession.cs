#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiStopSession
{
    [JsonProperty("session_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Session_id { get; set; } = default!;
}
