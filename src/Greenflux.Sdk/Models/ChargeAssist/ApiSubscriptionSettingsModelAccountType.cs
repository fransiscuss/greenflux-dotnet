#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ApiSubscriptionSettingsModelAccountType
{
    [EnumMember(Value = @"Anonymous")]
    Anonymous = 0,

    [EnumMember(Value = @"Account")]
    Account = 1,

    [EnumMember(Value = @"Hybrid")]
    Hybrid = 2,
}
