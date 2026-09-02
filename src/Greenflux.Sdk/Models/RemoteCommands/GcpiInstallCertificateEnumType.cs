#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiInstallCertificateEnumType
{
    [EnumMember(Value = @"V2GRootCertificate")]
    V2GRootCertificate = 0,

    [EnumMember(Value = @"MORootCertificate")]
    MORootCertificate = 1,

    [EnumMember(Value = @"CSMSRootCertificate")]
    CSMSRootCertificate = 2,

    [EnumMember(Value = @"ManufacturerRootCertificate")]
    ManufacturerRootCertificate = 3,
}
