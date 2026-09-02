#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum WalletTariffItemValidity
{
    [EnumMember(Value = @"VALID")]
    VALID = 0,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 1,

    [EnumMember(Value = @"NO_TARIFF_FOUND")]
    NO_TARIFF_FOUND = 2,

    [EnumMember(Value = @"NOT_COMPATIBLE")]
    NOT_COMPATIBLE = 3,

    [EnumMember(Value = @"ERROR")]
    ERROR = 4,
}
