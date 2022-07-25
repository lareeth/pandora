using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.EventHub.v2022_01_01_preview.EventHubsClustersConfiguration;

internal class Definition : ResourceDefinition
{
    public string Name => "EventHubsClustersConfiguration";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ConfigurationGetOperation(),
        new ConfigurationPatchOperation(),
    };
}