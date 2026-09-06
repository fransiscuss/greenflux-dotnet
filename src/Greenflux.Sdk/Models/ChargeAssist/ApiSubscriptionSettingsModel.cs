using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class ApiSubscriptionSettingsModel
{

    [JsonPropertyName("subscriber")]
    [JsonRequired]
    public string? Subscriber { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("requestChargeCardUrl")]
    public string? RequestChargeCardUrl { get; set; }

    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; set; }

    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; set; }

    [JsonPropertyName("supportPhoneNumber")]
    public string? SupportPhoneNumber { get; set; }

    [JsonPropertyName("driverAccount")]
    public bool? DriverAccount { get; set; }

    [JsonPropertyName("loginRequired")]
    public bool? LoginRequired { get; set; }

    [JsonPropertyName("allowExternalChargeCards")]
    public bool? AllowExternalChargeCards { get; set; }

    [JsonPropertyName("allowDirectCards")]
    public bool? AllowDirectCards { get; set; }

    [JsonPropertyName("whiteLabelApp")]
    public string? WhiteLabelApp { get; set; }

    [JsonPropertyName("versionSettings")]
    public AppVersionSettingsModel? VersionSettings { get; set; }

    [JsonPropertyName("cultureSettings")]
    public ICollection<SubscriptionCultureSettingsModel>? CultureSettings { get; set; }

    [JsonPropertyName("isWhiteLabelApp")]
    public bool? IsWhiteLabelApp { get; set; }

    [JsonPropertyName("supportedPaymentMethods")]
    public ICollection<SupportedPaymentMethods>? SupportedPaymentMethods { get; set; }

    [JsonPropertyName("measurementSystem")]
    public ApiSubscriptionSettingsModelMeasurementSystem? MeasurementSystem { get; set; }

    [JsonPropertyName("qrSetting")]
    public QrSettingModel? QrSetting { get; set; }

    [JsonPropertyName("autoChargeSetting")]
    public AutoChargeSettingModel? AutoChargeSetting { get; set; }

    [JsonPropertyName("retryFailedPaymentsSetting")]
    public RetryFailedPaymentsSettingModel? RetryFailedPaymentsSetting { get; set; }

    [JsonPropertyName("taxLabel")]
    public string? TaxLabel { get; set; }

    [JsonPropertyName("accountType")]
    public ApiSubscriptionSettingsModelAccountType? AccountType { get; set; }

    [JsonPropertyName("tariffMinSetting")]
    public TariffMinSettingModel? TariffMinSetting { get; set; }

    [JsonPropertyName("reject3rdPartyChargeCards")]
    public bool? Reject3rdPartyChargeCards { get; set; }

}
