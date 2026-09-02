#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum LocationModelType
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

    [EnumMember(Value = @"ALONG_MOTORWAY")]
    ALONG_MOTORWAY = 6,

    [EnumMember(Value = @"ON_DRIVEWAY")]
    ON_DRIVEWAY = 7,
}
