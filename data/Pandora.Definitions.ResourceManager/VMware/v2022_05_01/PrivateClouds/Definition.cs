using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.VMware.v2022_05_01.PrivateClouds;

internal class Definition : ResourceDefinition
{
    public string Name => "PrivateClouds";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListAdminCredentialsOperation(),
        new ListInSubscriptionOperation(),
        new RotateNsxtPasswordOperation(),
        new RotateVcenterPasswordOperation(),
        new UpdateOperation(),
    };
}
