#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum PhaseFilter
{
    [EnumMember(Value = @"L1")] L1 = 0,
    [EnumMember(Value = @"L2")] L2 = 1,
    [EnumMember(Value = @"L3")] L3 = 2,
}

