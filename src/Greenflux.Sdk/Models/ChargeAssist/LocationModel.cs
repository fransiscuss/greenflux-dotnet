#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationModel
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationModelType? Type { get; set; } = default!;

    [JsonProperty("name", Required = Required.AllowNull)]
    public string? Name { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } = default!;

    [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; } = default!;

    [JsonProperty("postalCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PostalCode { get; set; } = default!;

    [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; } = default!;

    [JsonProperty("coordinates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GeoLocationModel? Coordinates { get; set; } = default!;

    [JsonProperty("evses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EvseModel>? Evses { get; set; } = default!;

    [JsonProperty("directions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DisplayTextModel>? Directions { get; set; } = default!;

    [JsonProperty("operator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public BusinessDetailModel? Operator { get; set; } = default!;

    [JsonProperty("suboperator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public BusinessDetailModel? Suboperator { get; set; } = default!;

    [JsonProperty("owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public BusinessDetailModel? Owner { get; set; } = default!;

    [JsonProperty("facilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<Facilities>? Facilities { get; set; } = default!;

    [JsonProperty("openingHours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public HoursModel? OpeningHours { get; set; } = default!;

    [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ImageModel>? Images { get; set; } = default!;

    [JsonProperty("branding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public OperatorBrandingModel? Branding { get; set; } = default!;

    [JsonProperty("smartChargingEnabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SmartChargingEnabled { get; set; } = default!;

    [JsonProperty("reservationEnabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReservationEnabled { get; set; } = default!;

    [JsonProperty("dp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dp { get; set; } = default!;

    [JsonProperty("rfid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Rfid { get; set; } = default!;

    [JsonProperty("isPrivateLocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPrivateLocation { get; set; } = default!;

    [JsonProperty("pms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<Pms>? Pms { get; set; } = default!;

    [JsonProperty("issuers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Issuers { get; set; } = default!;

    [JsonProperty("availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationModelAvailability? Availability { get; set; } = default!;

    [JsonProperty("energyMix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public EnergyMixModel? EnergyMix { get; set; } = default!;

    [JsonProperty("isHomeCharger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsHomeCharger { get; set; } = default!;

    [JsonProperty("customProperties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomPropertyModel>? CustomProperties { get; set; } = default!;

    [JsonProperty("timeZone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZone { get; set; } = default!;

    [JsonProperty("preAuthAmountInCents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PreAuthAmountInCents { get; set; } = default!;

    [JsonProperty("cpsoId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CpsoId { get; set; } = default!;

    [JsonProperty("cpoCustomerId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CpoCustomerId { get; set; } = default!;

    [JsonProperty("paymentServiceProvider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public LocationModelPaymentServiceProvider? PaymentServiceProvider { get; set; } = default!;

}
