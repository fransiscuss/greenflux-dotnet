#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiCpoCustomersResponse
{
    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiCpoCustomer>? Data { get; set; } = default!;

    [JsonProperty("timestamp", Required = Required.Always)]
    public DateTimeOffset Timestamp { get; set; } = default!;

    [JsonProperty("status_code", Required = Required.Always)]
    public OcpiStatusCode Status_code { get; set; } = default!;

    [JsonProperty("status_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;
}
