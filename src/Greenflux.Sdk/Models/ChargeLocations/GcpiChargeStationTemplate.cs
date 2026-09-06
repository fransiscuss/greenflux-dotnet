using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>The Hardware template used for this Charge Station.</summary>
public partial class GcpiChargeStationTemplate
{
    [JsonPropertyName("template_id")]
    public string? TemplateId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    [JsonPropertyName("evse_templates")]
    public ICollection<GcpiEvseTemplate>? EvseTemplates { get; set; }
}
