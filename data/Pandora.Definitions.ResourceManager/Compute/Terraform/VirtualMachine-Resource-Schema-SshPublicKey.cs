using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Compute.Terraform;

public class VirtualMachineResourceSshPublicKeySchema
{

    [HclName("key_data")]
    [Optional]
    public string KeyData { get; set; }


    [HclName("path")]
    [Optional]
    public string Path { get; set; }

}