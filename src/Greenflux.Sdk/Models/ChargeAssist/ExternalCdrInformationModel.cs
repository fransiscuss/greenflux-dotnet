using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class ExternalCdrInformationModel
{

    [JsonPropertyName("appToken")]
    public string? AppToken { get; set; }

    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    [JsonPropertyName("externalSessionId")]
    public string? ExternalSessionId { get; set; }

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("transactionDetails")]
    public SessionTransactionDetailsModel? TransactionDetails { get; set; }

    [JsonPropertyName("pspPreAuthTransactionId")]
    public string? PspPreAuthTransactionId { get; set; }

    [JsonPropertyName("locationSummary")]
    public SessionLocationModel? LocationSummary { get; set; }

    [JsonPropertyName("receiptNumber")]
    public string? ReceiptNumber { get; set; }

}
