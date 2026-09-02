#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum DayOfWeekCustom
{
    [EnumMember(Value = @"MONDAY")] MONDAY = 0,
    [EnumMember(Value = @"TUESDAY")] TUESDAY = 1,
    [EnumMember(Value = @"WEDNESDAY")] WEDNESDAY = 2,
    [EnumMember(Value = @"THURSDAY")] THURSDAY = 3,
    [EnumMember(Value = @"FRIDAY")] FRIDAY = 4,
    [EnumMember(Value = @"SATURDAY")] SATURDAY = 5,
    [EnumMember(Value = @"SUNDAY")] SUNDAY = 6,
}

