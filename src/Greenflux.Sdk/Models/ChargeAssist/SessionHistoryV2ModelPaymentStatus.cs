#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum SessionHistoryV2ModelPaymentStatus
{
    [EnumMember(Value = @"Pending")]
    Pending = 0,

    [EnumMember(Value = @"Success")]
    Success = 1,

    [EnumMember(Value = @"EmspInvoice")]
    EmspInvoice = 2,

    [EnumMember(Value = @"AwaitingScheduledInvoice")]
    AwaitingScheduledInvoice = 3,

    [EnumMember(Value = @"External")]
    External = 4,

    [EnumMember(Value = @"Ignored")]
    Ignored = 5,

    [EnumMember(Value = @"Error")]
    Error = 6,
}
