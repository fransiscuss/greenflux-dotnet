using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum TokenRequestWhitelist_type
{
    [EnumMember(Value = @"Always")] Always = 0,
    [EnumMember(Value = @"AllowedOffline")] AllowedOffline = 1,
    [EnumMember(Value = @"Never")] Never = 2,
}

