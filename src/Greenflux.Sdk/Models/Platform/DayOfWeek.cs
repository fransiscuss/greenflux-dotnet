#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum DayOfWeek
{
    [EnumMember(Value = @"SUNDAY")] SUNDAY = 0,
    [EnumMember(Value = @"MONDAY")] MONDAY = 1,
    [EnumMember(Value = @"TUESDAY")] TUESDAY = 2,
    [EnumMember(Value = @"WEDNESDAY")] WEDNESDAY = 3,
    [EnumMember(Value = @"THURSDAY")] THURSDAY = 4,
    [EnumMember(Value = @"FRIDAY")] FRIDAY = 5,
    [EnumMember(Value = @"SATURDAY")] SATURDAY = 6,
}

