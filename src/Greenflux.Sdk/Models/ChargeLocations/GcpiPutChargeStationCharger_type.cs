using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiPutChargeStationCharger_type
{
    [EnumMember(Value = @"Public")]
    Public = 0,

    [EnumMember(Value = @"Home")]
    Home = 1,

    [EnumMember(Value = @"Business")]
    Business = 2,
}
