#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum CdrLineItemDimension
{
    [EnumMember(Value = @"TIME")]
    TIME = 0,

    [EnumMember(Value = @"ENERGY")]
    ENERGY = 1,

    [EnumMember(Value = @"PARKING_TIME")]
    PARKING_TIME = 2,

    [EnumMember(Value = @"FLAT")]
    FLAT = 3,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 4,
}
