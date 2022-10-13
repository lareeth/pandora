using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AppPlatform.v2022_09_01_preview.AppPlatform;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeploymentResourceStatusConstant
{
    [Description("Running")]
    Running,

    [Description("Stopped")]
    Stopped,
}
