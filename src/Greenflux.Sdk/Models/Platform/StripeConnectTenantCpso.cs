#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class StripeConnectTenantCpso
{
    [JsonProperty("cpso_external_id", Required = Required.Always)]
    public string Cpso_external_id { get; set; } = default!;
}

