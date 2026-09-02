#pragma warning disable CS1591
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class QrResponse
{

    [JsonProperty("valid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Valid { get; set; } = default!;

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("datasource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datasource { get; set; } = default!;

    [JsonProperty("operator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Operator { get; set; } = default!;

    [JsonProperty("locationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("ocpiLocationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OcpiLocationId { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseUid { get; set; } = default!;

    [JsonProperty("connectorId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectorId { get; set; } = default!;

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } = default!;

    [JsonProperty("embeddedUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmbeddedUrl { get; set; } = default!;

    [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDate { get; set; } = default!;

}
