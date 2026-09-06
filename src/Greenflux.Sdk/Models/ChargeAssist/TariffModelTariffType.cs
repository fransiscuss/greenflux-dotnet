using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum TariffModelTariffType
{
    [EnumMember(Value = @"WHOLESALE")]
    WHOLESALE = 0,

    [EnumMember(Value = @"RETAIL")]
    RETAIL = 1,
}
