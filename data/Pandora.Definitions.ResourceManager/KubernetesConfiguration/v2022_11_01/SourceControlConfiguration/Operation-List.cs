using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2022_11_01.SourceControlConfiguration;

internal class ListOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ProviderId();

    public override Type NestedItemType() => typeof(SourceControlConfigurationModel);

    public override string? UriSuffix() => "/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations";


}
