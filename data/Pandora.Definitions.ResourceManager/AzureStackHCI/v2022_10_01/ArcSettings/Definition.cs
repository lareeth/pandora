using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AzureStackHCI.v2022_10_01.ArcSettings;

internal class Definition : ResourceDefinition
{
    public string Name => "ArcSettings";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ArcSettingsCreateOperation(),
        new ArcSettingsDeleteOperation(),
        new ArcSettingsGetOperation(),
        new ArcSettingsListByClusterOperation(),
        new ArcSettingsUpdateOperation(),
        new CreateIdentityOperation(),
        new GeneratePasswordOperation(),
    };
}
