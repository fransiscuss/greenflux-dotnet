#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum StatusResponsePrioritySessionStatus
{
    [EnumMember(Value = @"NOT_APPLICABLE")]
    NOT_APPLICABLE = 0,

    [EnumMember(Value = @"OFF")]
    OFF = 1,

    [EnumMember(Value = @"ON")]
    ON = 2,
}
