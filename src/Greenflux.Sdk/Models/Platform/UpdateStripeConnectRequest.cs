using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class UpdateStripeConnectRequest
{
    [JsonPropertyName("cpsos")]
    public ICollection<StripeConnectTenantCpso>? Cpsos { get; set; }

    [JsonPropertyName("cpo_customers")]
    public ICollection<StripeConnectTenantCpoCustomer>? CpoCustomers { get; set; }

    [JsonPropertyName("application_fee_percentage")]
    public double? ApplicationFeePercentage { get; set; }

    [JsonPropertyName("customer_email")]
    public string? CustomerEmail { get; set; }

    [JsonPropertyName("business_details")]
    public Business_details3? Business_details { get; set; }

    [JsonPropertyName("enable_tax_calculation")]
    public bool? EnableTaxCalculation { get; set; }
}

