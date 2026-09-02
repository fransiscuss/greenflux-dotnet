#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class StripeConnect
{
    [JsonProperty("id", Required = Required.Always)]
    public string Id { get; set; } = default!;

    [JsonProperty("connection_name", Required = Required.Always)]
    public string Connection_name { get; set; } = default!;

    [JsonProperty("cpsos", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StripeConnectTenantCpso>? Cpsos { get; set; } = default!;

    [JsonProperty("cpo_customers", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StripeConnectTenantCpoCustomer>? Cpo_customers { get; set; } = default!;

    [JsonProperty("connect_account_id", Required = Required.Always)]
    public string Connect_account_id { get; set; } = default!;

    [JsonProperty("application_fee_percentage", NullValueHandling = NullValueHandling.Ignore)]
    public double? Application_fee_percentage { get; set; } = default!;

    [JsonProperty("created_date", Required = Required.Always)]
    public DateTimeOffset Created_date { get; set; } = default!;

    [JsonProperty("connected_on", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Connected_on { get; set; } = default!;

    [JsonProperty("onboarding_url", NullValueHandling = NullValueHandling.Ignore)]
    public Uri? Onboarding_url { get; set; } = default!;

    [JsonProperty("customer_email", NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer_email { get; set; } = default!;

    [JsonProperty("business_details", NullValueHandling = NullValueHandling.Ignore)]
    public Business_details2? Business_details { get; set; } = default!;

    [JsonProperty("enable_tax_calculation", Required = Required.Always)]
    public bool Enable_tax_calculation { get; set; } = default!;
}

