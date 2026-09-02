#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ChargeAssistPaymentMethodType
{
    [EnumMember(Value = @"CHARGE_CARD")]
    CHARGE_CARD = 0,

    [EnumMember(Value = @"OTHER")]
    OTHER = 1,
}
