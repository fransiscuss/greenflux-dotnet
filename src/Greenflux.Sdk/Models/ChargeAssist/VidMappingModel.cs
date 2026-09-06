using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class VidMappingModel
{

    [JsonPropertyName("vid")]
    public string? Vid { get; set; }

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("paymentMethodId")]
    public string? PaymentMethodId { get; set; }

    [JsonPropertyName("emailId")]
    public string? EmailId { get; set; }

    [JsonPropertyName("vidStatus")]
    public VidMappingModelVidStatus? VidStatus { get; set; }

}
