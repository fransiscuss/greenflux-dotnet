#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class ExternalCdrInformationModel
{

    [JsonProperty("appToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppToken { get; set; } = default!;

    [JsonProperty("sessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SessionId { get; set; } = default!;

    [JsonProperty("externalSessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExternalSessionId { get; set; } = default!;

    [JsonProperty("locationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("transactionDetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionTransactionDetailsModel? TransactionDetails { get; set; } = default!;

    [JsonProperty("pspPreAuthTransactionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PspPreAuthTransactionId { get; set; } = default!;

    [JsonProperty("locationSummary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SessionLocationModel? LocationSummary { get; set; } = default!;

    [JsonProperty("receiptNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReceiptNumber { get; set; } = default!;

}
