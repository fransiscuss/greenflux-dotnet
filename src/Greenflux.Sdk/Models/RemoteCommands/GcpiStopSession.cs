using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiStopSession
{
    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }
}
