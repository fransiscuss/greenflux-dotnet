#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum SessionHistoryV2ModelVidStatus
{
    [EnumMember(Value = @"VID_NOT_AVAILABLE")]
    VID_NOT_AVAILABLE = 0,

    [EnumMember(Value = @"VID_NOT_REGISTERED")]
    VID_NOT_REGISTERED = 1,

    [EnumMember(Value = @"VID_REGISTRATION_IN_PROGRESS")]
    VID_REGISTRATION_IN_PROGRESS = 2,

    [EnumMember(Value = @"VID_REGISTERED")]
    VID_REGISTERED = 3,

    [EnumMember(Value = @"VID_DEREGISTERED")]
    VID_DEREGISTERED = 4,
}
