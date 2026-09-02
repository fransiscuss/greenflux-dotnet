#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

/// <summary>Internal data model for batch update responses.</summary>
public partial class Data
{
    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Report_id { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public DataStatus? Status { get; set; } = default!;

    [JsonProperty("validation_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Validation_error { get; set; } = default!;

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
