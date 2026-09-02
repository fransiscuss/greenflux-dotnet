#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class HighPriorityResponse
{

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public HighPriorityResponseStatus? Status { get; set; } = default!;

}
