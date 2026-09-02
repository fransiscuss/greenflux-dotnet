#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum LinkedPaymentMethodType
{
    [EnumMember(Value = @"CHARGE_CARD")]
    CHARGE_CARD = 0,

    [EnumMember(Value = @"MASTER_CARD")]
    MASTER_CARD = 1,

    [EnumMember(Value = @"VISA")]
    VISA = 2,

    [EnumMember(Value = @"AMEX")]
    AMEX = 3,

    [EnumMember(Value = @"APPLE_PAY")]
    APPLE_PAY = 4,

    [EnumMember(Value = @"GOOGLE_PAY")]
    GOOGLE_PAY = 5,

    [EnumMember(Value = @"IDEAL")]
    IDEAL = 6,

    [EnumMember(Value = @"BANCONTACT")]
    BANCONTACT = 7,

    [EnumMember(Value = @"SOFORT")]
    SOFORT = 8,

    [EnumMember(Value = @"WALLET")]
    WALLET = 9,

    [EnumMember(Value = @"CARD_OTHER")]
    CARD_OTHER = 10,

    [EnumMember(Value = @"EXTERNAL")]
    EXTERNAL = 11,
}
