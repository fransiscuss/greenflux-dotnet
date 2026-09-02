#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class ValidationResponseV2
{

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } = default!;

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } = default!;

    [JsonProperty("context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Context { get; set; } = default!;

    [JsonProperty("validationStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ValidationResponseV2ValidationStatus? ValidationStatus { get; set; } = default!;

}
