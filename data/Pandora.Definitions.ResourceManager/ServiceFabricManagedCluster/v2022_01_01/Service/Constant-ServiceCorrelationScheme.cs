using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ServiceFabricManagedCluster.v2022_01_01.Service;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ServiceCorrelationSchemeConstant
{
    [Description("AlignedAffinity")]
    AlignedAffinity,

    [Description("NonAlignedAffinity")]
    NonAlignedAffinity,
}
