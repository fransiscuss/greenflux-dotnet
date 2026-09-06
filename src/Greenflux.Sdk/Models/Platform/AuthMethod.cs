using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum AuthMethod
{
    [EnumMember(Value = @"AUTH_REQUEST")] AUTH_REQUEST = 0,
    [EnumMember(Value = @"WHITELIST")] WHITELIST = 1,
}

