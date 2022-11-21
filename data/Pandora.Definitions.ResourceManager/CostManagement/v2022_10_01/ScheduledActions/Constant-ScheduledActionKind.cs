using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2022_10_01.ScheduledActions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ScheduledActionKindConstant
{
    [Description("Email")]
    Email,

    [Description("InsightAlert")]
    InsightAlert,
}