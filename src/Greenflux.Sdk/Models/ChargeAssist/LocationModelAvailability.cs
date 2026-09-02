#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum LocationModelAvailability
{
    [EnumMember(Value = @"NONE")]
    NONE = 0,

    [EnumMember(Value = @"LOW")]
    LOW = 1,

    [EnumMember(Value = @"MODERATE")]
    MODERATE = 2,

    [EnumMember(Value = @"HIGH")]
    HIGH = 3,
}
