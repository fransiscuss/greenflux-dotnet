using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiEvseTemplate
{
    [JsonPropertyName("evse_sequence_number")]
    public int? EvseSequenceNumber { get; set; }

    [JsonPropertyName("capabilities")]
    public ICollection<string>? Capabilities { get; set; }

    [JsonPropertyName("connector_templates")]
    public ICollection<GcpiConnectorTemplate>? ConnectorTemplates { get; set; }
}
