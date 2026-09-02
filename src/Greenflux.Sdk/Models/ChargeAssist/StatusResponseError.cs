#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum StatusResponseError
{
    [EnumMember(Value = @"INVALID_TOKEN")]
    INVALID_TOKEN = 0,

    [EnumMember(Value = @"EVSE_NOT_AVAILABLE")]
    EVSE_NOT_AVAILABLE = 1,

    [EnumMember(Value = @"COMMAND_TIMED_OUT")]
    COMMAND_TIMED_OUT = 2,

    [EnumMember(Value = @"SOFT_TIME_OUT")]
    SOFT_TIME_OUT = 3,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 4,
}
