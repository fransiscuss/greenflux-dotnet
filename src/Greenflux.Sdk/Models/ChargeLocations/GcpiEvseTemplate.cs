#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiEvseTemplate
{
    [JsonProperty("evse_sequence_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Evse_sequence_number { get; set; } = default!;

    [JsonProperty("capabilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Capabilities { get; set; } = default!;

    [JsonProperty("connector_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiConnectorTemplate>? Connector_templates { get; set; } = default!;
}
