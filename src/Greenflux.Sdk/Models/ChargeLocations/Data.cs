using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>Internal data model for batch update responses.</summary>
public partial class Data
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
