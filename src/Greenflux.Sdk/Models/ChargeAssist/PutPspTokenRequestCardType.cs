#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum PutPspTokenRequestCardType
{
    [EnumMember(Value = @"MASTER_CARD")]
    MASTER_CARD = 0,

    [EnumMember(Value = @"VISA")]
    VISA = 1,

    [EnumMember(Value = @"AMEX")]
    AMEX = 2,

    [EnumMember(Value = @"APPLE_PAY")]
    APPLE_PAY = 3,

    [EnumMember(Value = @"GOOGLE_PAY")]
    GOOGLE_PAY = 4,

    [EnumMember(Value = @"IDEAL")]
    IDEAL = 5,

    [EnumMember(Value = @"BANCONTACT")]
    BANCONTACT = 6,

    [EnumMember(Value = @"SOFORT")]
    SOFORT = 7,

    [EnumMember(Value = @"Wallet")]
    Wallet = 8,

    [EnumMember(Value = @"CARD_OTHER")]
    CARD_OTHER = 9,
}
