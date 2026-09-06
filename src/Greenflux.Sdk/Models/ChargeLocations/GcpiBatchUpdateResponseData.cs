using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchUpdateResponseData
{
    [JsonPropertyName("report_id")]
    public string? ReportId { get; set; }

    [JsonPropertyName("status")]
    public DataStatus? Status { get; set; }

    [JsonPropertyName("validation_error")]
    public string? ValidationError { get; set; }

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
