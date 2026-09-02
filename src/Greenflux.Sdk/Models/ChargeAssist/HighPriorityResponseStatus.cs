#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum HighPriorityResponseStatus
{
    [EnumMember(Value = @"APPROVED")]
    APPROVED = 0,

    [EnumMember(Value = @"DENIED")]
    DENIED = 1,

    [EnumMember(Value = @"ERROR")]
    ERROR = 2,
}
