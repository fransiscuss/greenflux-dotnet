#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum FailedSessionPaymentModelPaymentStatus
{
    [EnumMember(Value = @"PENDING")]
    PENDING = 0,

    [EnumMember(Value = @"SUCCESS")]
    SUCCESS = 1,

    [EnumMember(Value = @"EMSP_INVOICE")]
    EMSP_INVOICE = 2,

    [EnumMember(Value = @"IGNORED")]
    IGNORED = 3,

    [EnumMember(Value = @"ERROR")]
    ERROR = 4,
}
