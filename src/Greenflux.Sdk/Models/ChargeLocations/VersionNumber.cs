#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum VersionNumber
{
    [EnumMember(Value = @"2.0")]
    _2_0 = 0,
}
