#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiChargeStationCharger_type
{
    [EnumMember(Value = @"Public")]
    Public = 0,

    [EnumMember(Value = @"Home")]
    Home = 1,

    [EnumMember(Value = @"Business")]
    Business = 2,
}
