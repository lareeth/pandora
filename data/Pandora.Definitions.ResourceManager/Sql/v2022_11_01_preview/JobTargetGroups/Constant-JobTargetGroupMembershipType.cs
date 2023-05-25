using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.JobTargetGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum JobTargetGroupMembershipTypeConstant
{
    [Description("Exclude")]
    Exclude,

    [Description("Include")]
    Include,
}
