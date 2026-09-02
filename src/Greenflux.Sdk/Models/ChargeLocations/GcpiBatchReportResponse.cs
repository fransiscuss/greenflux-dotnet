#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchReportResponse
{
    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Report_id { get; set; } = default!;

    [JsonProperty("cpo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_id { get; set; } = default!;

    [JsonProperty("creation_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Creation_date { get; set; } = default!;

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ChargeStationConfigurationsBatchUpdateReportStatus? Status { get; set; } = default!;
}
