using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Compute.Terraform;

public class VirtualMachineScaleSetResourceVirtualMachineScaleSetPublicIPAddressConfigurationSchema
{

    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [HclName("properties")]
    [Optional]
    public List<VirtualMachineScaleSetResourceVirtualMachineScaleSetPublicIPAddressConfigurationPropertiesSchema> Properties { get; set; }


    [HclName("sku")]
    [Optional]
    public List<VirtualMachineScaleSetResourcePublicIPAddressSkuSchema> Sku { get; set; }

}