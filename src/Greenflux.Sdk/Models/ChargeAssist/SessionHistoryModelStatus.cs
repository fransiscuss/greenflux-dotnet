#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum SessionHistoryModelStatus
{
    [EnumMember(Value = @"REQUESTED")]
    REQUESTED = 0,

    [EnumMember(Value = @"REJECTED")]
    REJECTED = 1,

    [EnumMember(Value = @"STARTING")]
    STARTING = 2,

    [EnumMember(Value = @"CHARGING")]
    CHARGING = 3,

    [EnumMember(Value = @"STOPPING")]
    STOPPING = 4,

    [EnumMember(Value = @"COMPLETED")]
    COMPLETED = 5,

    [EnumMember(Value = @"CDR_AVAILABLE")]
    CDR_AVAILABLE = 6,

    [EnumMember(Value = @"PARKING")]
    PARKING = 7,

    [EnumMember(Value = @"TIMEOUT")]
    TIMEOUT = 8,

    [EnumMember(Value = @"CANCELLED")]
    CANCELLED = 9,

    [EnumMember(Value = @"ERROR")]
    ERROR = 10,
}
