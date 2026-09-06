using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class QrResponse
{

    [JsonPropertyName("valid")]
    public bool? Valid { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("datasource")]
    public string? Datasource { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("ocpiLocationId")]
    public string? OcpiLocationId { get; set; }

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("connectorId")]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("embeddedUrl")]
    public string? EmbeddedUrl { get; set; }

    [JsonPropertyName("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

}
