using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationModel
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public LocationModelType? Type { get; set; }

    [JsonPropertyName("name")]
    [JsonRequired]
    public string? Name { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("coordinates")]
    public GeoLocationModel? Coordinates { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<EvseModel>? Evses { get; set; }

    [JsonPropertyName("directions")]
    public ICollection<DisplayTextModel>? Directions { get; set; }

    [JsonPropertyName("operator")]
    public BusinessDetailModel? Operator { get; set; }

    [JsonPropertyName("suboperator")]
    public BusinessDetailModel? Suboperator { get; set; }

    [JsonPropertyName("owner")]
    public BusinessDetailModel? Owner { get; set; }

    [JsonPropertyName("facilities")]
    public ICollection<Facilities>? Facilities { get; set; }

    [JsonPropertyName("openingHours")]
    public HoursModel? OpeningHours { get; set; }

    [JsonPropertyName("images")]
    public ICollection<ImageModel>? Images { get; set; }

    [JsonPropertyName("branding")]
    public OperatorBrandingModel? Branding { get; set; }

    [JsonPropertyName("smartChargingEnabled")]
    public bool? SmartChargingEnabled { get; set; }

    [JsonPropertyName("reservationEnabled")]
    public bool? ReservationEnabled { get; set; }

    [JsonPropertyName("dp")]
    public bool? Dp { get; set; }

    [JsonPropertyName("rfid")]
    public bool? Rfid { get; set; }

    [JsonPropertyName("isPrivateLocation")]
    public bool? IsPrivateLocation { get; set; }

    [JsonPropertyName("pms")]
    public ICollection<Pms>? Pms { get; set; }

    [JsonPropertyName("issuers")]
    public ICollection<string>? Issuers { get; set; }

    [JsonPropertyName("availability")]
    public LocationModelAvailability? Availability { get; set; }

    [JsonPropertyName("energyMix")]
    public EnergyMixModel? EnergyMix { get; set; }

    [JsonPropertyName("isHomeCharger")]
    public bool? IsHomeCharger { get; set; }

    [JsonPropertyName("customProperties")]
    public ICollection<CustomPropertyModel>? CustomProperties { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("preAuthAmountInCents")]
    public int? PreAuthAmountInCents { get; set; }

    [JsonPropertyName("cpsoId")]
    public string? CpsoId { get; set; }

    [JsonPropertyName("cpoCustomerId")]
    public string? CpoCustomerId { get; set; }

    [JsonPropertyName("paymentServiceProvider")]
    public LocationModelPaymentServiceProvider? PaymentServiceProvider { get; set; }

}
