using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class StripeConnectTenantCpoCustomer
{
    [JsonPropertyName("cpo_customer_external_id")]
    [JsonRequired]
    public string CpoCustomerExternalId { get; set; } = default!;

    [JsonPropertyName("cpso_id")]
    [JsonRequired]
    public string CpsoId { get; set; } = default!;
}

