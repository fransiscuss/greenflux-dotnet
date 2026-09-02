#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum StatusResponseStartMethod
{
    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 0,

    [EnumMember(Value = @"APP")]
    APP = 1,

    [EnumMember(Value = @"NOT_APP")]
    NOT_APP = 2,
}
