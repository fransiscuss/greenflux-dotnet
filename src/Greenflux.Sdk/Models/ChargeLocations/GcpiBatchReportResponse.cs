using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchReportResponse
{
    [JsonPropertyName("report_id")]
    public string? ReportId { get; set; }

    [JsonPropertyName("cpo_id")]
    public string? CpoId { get; set; }

    [JsonPropertyName("creation_date")]
    public DateTimeOffset? CreationDate { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("status")]
    public ChargeStationConfigurationsBatchUpdateReportStatus? Status { get; set; }
}
