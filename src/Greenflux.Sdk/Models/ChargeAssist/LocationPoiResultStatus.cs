#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum LocationPoiResultStatus
{
    [EnumMember(Value = @"AVAILABLE")]
    AVAILABLE = 0,

    [EnumMember(Value = @"SEMI_AVAILABLE")]
    SEMI_AVAILABLE = 1,

    [EnumMember(Value = @"UN_AVAILABLE")]
    UN_AVAILABLE = 2,

    [EnumMember(Value = @"INOPERATIVE")]
    INOPERATIVE = 3,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 4,
}
