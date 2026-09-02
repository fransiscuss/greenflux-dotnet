#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum CapacityUpdateMethod
{
    [EnumMember(Value = @"DEFAULT")] DEFAULT = 0,
    [EnumMember(Value = @"FILE")] FILE = 1,
    [EnumMember(Value = @"API")] API = 2,
    [EnumMember(Value = @"EXTERNALMETER")] EXTERNALMETER = 3,
    [EnumMember(Value = @"PARENTGROUP")] PARENTGROUP = 4,
}

