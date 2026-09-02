#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum PaymentStatusRequestPaymentStatus
{
    [EnumMember(Value = @"Pending")]
    Pending = 0,

    [EnumMember(Value = @"Success")]
    Success = 1,

    [EnumMember(Value = @"Error")]
    Error = 2,
}
