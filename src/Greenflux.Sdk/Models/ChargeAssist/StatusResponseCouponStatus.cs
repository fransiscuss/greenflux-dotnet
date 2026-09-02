#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum StatusResponseCouponStatus
{
    [EnumMember(Value = @"NOT_APPLICABLE")]
    NOT_APPLICABLE = 0,

    [EnumMember(Value = @"NOT_APPLIED")]
    NOT_APPLIED = 1,

    [EnumMember(Value = @"APPLIED")]
    APPLIED = 2,
}
