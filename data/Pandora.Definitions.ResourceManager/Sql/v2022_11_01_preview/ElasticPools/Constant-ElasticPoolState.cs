using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.ElasticPools;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ElasticPoolStateConstant
{
    [Description("Creating")]
    Creating,

    [Description("Disabled")]
    Disabled,

    [Description("Ready")]
    Ready,
}
