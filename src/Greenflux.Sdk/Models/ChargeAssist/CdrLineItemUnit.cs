#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum CdrLineItemUnit
{
    [EnumMember(Value = @"MIN")]
    MIN = 0,

    [EnumMember(Value = @"KWH")]
    KWH = 1,

    [EnumMember(Value = @"MONEY")]
    MONEY = 2,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 3,
}
