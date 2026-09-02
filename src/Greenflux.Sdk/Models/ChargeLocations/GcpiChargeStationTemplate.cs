#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

/// <summary>The Hardware template used for this Charge Station.</summary>
public partial class GcpiChargeStationTemplate
{
    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Template_id { get; set; } = default!;

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant_id { get; set; } = default!;

    [JsonProperty("evse_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiEvseTemplate>? Evse_templates { get; set; } = default!;
}
