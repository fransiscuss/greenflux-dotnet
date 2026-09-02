#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class StripeConnectTenantCpoCustomer
{
    [JsonProperty("cpo_customer_external_id", Required = Required.Always)]
    public string Cpo_customer_external_id { get; set; } = default!;

    [JsonProperty("cpso_id", Required = Required.Always)]
    public string Cpso_id { get; set; } = default!;
}

