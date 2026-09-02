#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ChargeAssistPowerType
{
    [EnumMember(Value = @"AC")]
    AC = 0,

    [EnumMember(Value = @"DC")]
    DC = 1,
}
