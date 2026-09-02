#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ValidationResponseV2ValidationStatus
{
    [EnumMember(Value = @"Valid")]
    Valid = 0,

    [EnumMember(Value = @"Warning")]
    Warning = 1,

    [EnumMember(Value = @"Error")]
    Error = 2,
}
