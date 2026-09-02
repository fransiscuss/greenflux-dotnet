#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiLocationType
{
    [EnumMember(Value = @"ON_STREET")]
    ON_STREET = 0,

    [EnumMember(Value = @"PARKING_GARAGE")]
    PARKING_GARAGE = 1,

    [EnumMember(Value = @"UNDERGROUND_GARAGE")]
    UNDERGROUND_GARAGE = 2,

    [EnumMember(Value = @"PARKING_LOT")]
    PARKING_LOT = 3,

    [EnumMember(Value = @"OTHER")]
    OTHER = 4,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 5,
}
