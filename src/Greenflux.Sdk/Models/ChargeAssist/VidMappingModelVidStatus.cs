#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum VidMappingModelVidStatus
{
    [EnumMember(Value = @"VID_REQUESTED")]
    VID_REQUESTED = 0,

    [EnumMember(Value = @"VID_REGISTERED")]
    VID_REGISTERED = 1,

    [EnumMember(Value = @"VID_ONHOLD")]
    VID_ONHOLD = 2,
}
