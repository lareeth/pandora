using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerService.v2022_09_02_preview.ManagedClusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OutboundTypeConstant
{
    [Description("loadBalancer")]
    LoadBalancer,

    [Description("managedNATGateway")]
    ManagedNATGateway,

    [Description("userAssignedNATGateway")]
    UserAssignedNATGateway,

    [Description("userDefinedRouting")]
    UserDefinedRouting,
}