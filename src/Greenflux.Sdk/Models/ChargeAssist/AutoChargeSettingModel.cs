#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class AutoChargeSettingModel
{

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } = default!;

    [JsonProperty("excludedSources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? ExcludedSources { get; set; } = default!;

    [JsonProperty("paymentMethods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<PaymentMethods>? PaymentMethods { get; set; } = default!;

}
