#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class BadRequestObjectResult
{

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Value { get; set; } = default!;

    [JsonProperty("formatters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IOutputFormatter>? Formatters { get; set; } = default!;

    [JsonProperty("contentTypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? ContentTypes { get; set; } = default!;

    [JsonProperty("declaredType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeclaredType { get; set; } = default!;

    [JsonProperty("statusCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusCode { get; set; } = default!;

}
