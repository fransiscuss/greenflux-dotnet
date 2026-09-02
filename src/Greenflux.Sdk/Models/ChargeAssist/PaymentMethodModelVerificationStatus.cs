#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum PaymentMethodModelVerificationStatus
{
    [EnumMember(Value = @"PENDING")]
    PENDING = 0,

    [EnumMember(Value = @"VALID")]
    VALID = 1,

    [EnumMember(Value = @"INVALID")]
    INVALID = 2,
}
