#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ApiSubscriptionSettingsModelMeasurementSystem
{
    [EnumMember(Value = @"Metric")]
    Metric = 0,

    [EnumMember(Value = @"Imperial")]
    Imperial = 1,
}
