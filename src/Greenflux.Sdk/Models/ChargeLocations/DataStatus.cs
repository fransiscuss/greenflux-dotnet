#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum DataStatus
{
    [EnumMember(Value = @"Inprogress")]
    Inprogress = 0,

    [EnumMember(Value = @"Failed")]
    Failed = 1,
}
