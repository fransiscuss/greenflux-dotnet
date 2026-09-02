#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class ApiSubscriptionSettingsModel
{

    [JsonProperty("subscriber", Required = Required.AllowNull)]
    public string? Subscriber { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

    [JsonProperty("requestChargeCardUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestChargeCardUrl { get; set; } = default!;

    [JsonProperty("supportUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupportUrl { get; set; } = default!;

    [JsonProperty("supportEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupportEmail { get; set; } = default!;

    [JsonProperty("supportPhoneNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupportPhoneNumber { get; set; } = default!;

    [JsonProperty("driverAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DriverAccount { get; set; } = default!;

    [JsonProperty("loginRequired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LoginRequired { get; set; } = default!;

    [JsonProperty("allowExternalChargeCards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowExternalChargeCards { get; set; } = default!;

    [JsonProperty("allowDirectCards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowDirectCards { get; set; } = default!;

    [JsonProperty("whiteLabelApp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WhiteLabelApp { get; set; } = default!;

    [JsonProperty("versionSettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AppVersionSettingsModel? VersionSettings { get; set; } = default!;

    [JsonProperty("cultureSettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SubscriptionCultureSettingsModel>? CultureSettings { get; set; } = default!;

    [JsonProperty("isWhiteLabelApp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsWhiteLabelApp { get; set; } = default!;

    [JsonProperty("supportedPaymentMethods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<SupportedPaymentMethods>? SupportedPaymentMethods { get; set; } = default!;

    [JsonProperty("measurementSystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ApiSubscriptionSettingsModelMeasurementSystem? MeasurementSystem { get; set; } = default!;

    [JsonProperty("qrSetting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public QrSettingModel? QrSetting { get; set; } = default!;

    [JsonProperty("autoChargeSetting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutoChargeSettingModel? AutoChargeSetting { get; set; } = default!;

    [JsonProperty("retryFailedPaymentsSetting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public RetryFailedPaymentsSettingModel? RetryFailedPaymentsSetting { get; set; } = default!;

    [JsonProperty("taxLabel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxLabel { get; set; } = default!;

    [JsonProperty("accountType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ApiSubscriptionSettingsModelAccountType? AccountType { get; set; } = default!;

    [JsonProperty("tariffMinSetting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TariffMinSettingModel? TariffMinSetting { get; set; } = default!;

    [JsonProperty("reject3rdPartyChargeCards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reject3rdPartyChargeCards { get; set; } = default!;

}
