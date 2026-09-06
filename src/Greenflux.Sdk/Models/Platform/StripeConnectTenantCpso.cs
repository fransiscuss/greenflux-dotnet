using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class StripeConnectTenantCpso
{
    [JsonPropertyName("cpso_external_id")]
    [JsonRequired]
    public string CpsoExternalId { get; set; } = default!;
}

