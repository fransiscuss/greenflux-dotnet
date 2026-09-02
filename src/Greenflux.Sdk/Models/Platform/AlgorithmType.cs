#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum AlgorithmType
{
    [EnumMember(Value = @"NONE")] NONE = 0,
    [EnumMember(Value = @"CAPACITYMANAGEMENTDEFAULT")] CAPACITYMANAGEMENTDEFAULT = 1,
    [EnumMember(Value = @"CUSTOMERCONFIGUREDTOUALGORITHM")] CUSTOMERCONFIGUREDTOUALGORITHM = 2,
    [EnumMember(Value = @"CAPACITYMANAGEMENTDC")] CAPACITYMANAGEMENTDC = 3,
}

