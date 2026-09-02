#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiAuthRuleType
{
    [EnumMember(Value = @"CustomerExternalId")]
    CustomerExternalId = 0,

    [EnumMember(Value = @"ClosedGroups")]
    ClosedGroups = 1,

    [EnumMember(Value = @"HomeToken")]
    HomeToken = 2,
}
