#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum ChargeStationConfigurationsBatchUpdateReportStatus
{
    [EnumMember(Value = @"Inprogress")]
    Inprogress = 0,

    [EnumMember(Value = @"Completed")]
    Completed = 1,

    [EnumMember(Value = @"Failed")]
    Failed = 2,
}
