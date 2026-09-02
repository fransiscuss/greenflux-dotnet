#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum Order
{
    [EnumMember(Value = @"ASC")] ASC = 0,
    [EnumMember(Value = @"DESC")] DESC = 1,
}

