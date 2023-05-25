using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.LongTermRetentionBackups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DatabaseStateConstant
{
    [Description("All")]
    All,

    [Description("Deleted")]
    Deleted,

    [Description("Live")]
    Live,
}
