#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class VidMappingModel
{

    [JsonProperty("vid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Vid { get; set; } = default!;

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("paymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentMethodId { get; set; } = default!;

    [JsonProperty("emailId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailId { get; set; } = default!;

    [JsonProperty("vidStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public VidMappingModelVidStatus? VidStatus { get; set; } = default!;

}
