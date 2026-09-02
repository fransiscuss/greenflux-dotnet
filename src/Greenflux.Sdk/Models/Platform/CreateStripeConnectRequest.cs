#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CreateStripeConnectRequest
{
    [JsonProperty("connection_name", Required = Required.Always)]
    public string Connection_name { get; set; } = default!;

    [JsonProperty("cpsos", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StripeConnectTenantCpso>? Cpsos { get; set; } = default!;

    [JsonProperty("cpo_customers", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StripeConnectTenantCpoCustomer>? Cpo_customers { get; set; } = default!;

    [JsonProperty("application_fee_percentage", NullValueHandling = NullValueHandling.Ignore)]
    public double? Application_fee_percentage { get; set; } = default!;

    [JsonProperty("customer_email", NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer_email { get; set; } = default!;

    [JsonProperty("business_details", NullValueHandling = NullValueHandling.Ignore)]
    public Business_details? Business_details { get; set; } = default!;

    [JsonProperty("enable_tax_calculation", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enable_tax_calculation { get; set; } = default!;
}

