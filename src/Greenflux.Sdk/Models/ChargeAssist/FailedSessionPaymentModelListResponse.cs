#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class FailedSessionPaymentModelListResponse
{

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FailedSessionPaymentModel>? Data { get; set; } = default!;

    [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MetaInfo? Meta { get; set; } = default!;

}
