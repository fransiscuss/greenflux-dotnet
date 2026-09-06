using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class StripeConnect
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    [JsonPropertyName("connection_name")]
    [JsonRequired]
    public string ConnectionName { get; set; } = default!;

    [JsonPropertyName("cpsos")]
    public ICollection<StripeConnectTenantCpso>? Cpsos { get; set; }

    [JsonPropertyName("cpo_customers")]
    public ICollection<StripeConnectTenantCpoCustomer>? CpoCustomers { get; set; }

    [JsonPropertyName("connect_account_id")]
    [JsonRequired]
    public string ConnectAccountId { get; set; } = default!;

    [JsonPropertyName("application_fee_percentage")]
    public double? ApplicationFeePercentage { get; set; }

    [JsonPropertyName("created_date")]
    [JsonRequired]
    public DateTimeOffset CreatedDate { get; set; } = default!;

    [JsonPropertyName("connected_on")]
    public DateTimeOffset? ConnectedOn { get; set; }

    [JsonPropertyName("onboarding_url")]
    public Uri? OnboardingUrl { get; set; }

    [JsonPropertyName("customer_email")]
    public string? CustomerEmail { get; set; }

    [JsonPropertyName("business_details")]
    public Business_details2? Business_details { get; set; }

    [JsonPropertyName("enable_tax_calculation")]
    [JsonRequired]
    public bool EnableTaxCalculation { get; set; } = default!;
}

