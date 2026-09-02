#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum LocationModelPaymentServiceProvider
{
    [EnumMember(Value = @"Stripe")]
    Stripe = 0,

    [EnumMember(Value = @"Lemonway")]
    Lemonway = 1,

    [EnumMember(Value = @"Adyen")]
    Adyen = 2,
}
