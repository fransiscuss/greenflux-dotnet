#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class ValidationResponse
{

    [JsonProperty("validationMessages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValidationMessage>? ValidationMessages { get; set; } = default!;

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } = default!;

    [JsonProperty("developerMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeveloperMessage { get; set; } = default!;

}
