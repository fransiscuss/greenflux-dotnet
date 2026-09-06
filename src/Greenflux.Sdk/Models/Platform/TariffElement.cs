using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class TariffElement
{
    [JsonPropertyName("price_components")]
    public ICollection<PriceComponent>? PriceComponents { get; set; }

    [JsonPropertyName("restrictions")]
    public TariffRestrictions? Restrictions { get; set; }

    [JsonPropertyName("billingRuleReference")]
    public string? BillingRuleReference { get; set; }
}

