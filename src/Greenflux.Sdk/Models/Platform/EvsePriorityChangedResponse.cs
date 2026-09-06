using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class EvsePriorityChangedResponse
{
    [JsonPropertyName("capacity_group_id")]
    public string? CapacityGroupId { get; set; }

    [JsonPropertyName("cpo_external_id")]
    public string? CpoExternalId { get; set; }

    [JsonPropertyName("evse_uid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }
}

