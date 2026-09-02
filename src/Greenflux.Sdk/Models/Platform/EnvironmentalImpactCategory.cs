#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum EnvironmentalImpactCategory
{
    [EnumMember(Value = @"NUCLEAR_WASTE")] NUCLEAR_WASTE = 0,
    [EnumMember(Value = @"CARBON_DIOXIDE")] CARBON_DIOXIDE = 1,
}

