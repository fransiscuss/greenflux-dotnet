using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class AutoChargeSettingModel
{

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("excludedSources")]
    public ICollection<string>? ExcludedSources { get; set; }

    [JsonPropertyName("paymentMethods")]
    public ICollection<PaymentMethods>? PaymentMethods { get; set; }

}
