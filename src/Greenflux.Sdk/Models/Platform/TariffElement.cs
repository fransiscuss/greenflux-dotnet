#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class TariffElement
{
    [JsonProperty("price_components", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PriceComponent>? Price_components { get; set; } = default!;

    [JsonProperty("restrictions", NullValueHandling = NullValueHandling.Ignore)]
    public TariffRestrictions? Restrictions { get; set; } = default!;

    [JsonProperty("billingRuleReference", NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingRuleReference { get; set; } = default!;
}

