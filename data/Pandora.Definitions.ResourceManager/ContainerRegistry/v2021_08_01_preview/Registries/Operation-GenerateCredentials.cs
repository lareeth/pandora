using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2021_08_01_preview.Registries;

internal class GenerateCredentialsOperation : Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
                HttpStatusCode.OK,
        };

    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(GenerateCredentialsParametersModel);

    public override ResourceID? ResourceId() => new RegistryId();

    public override Type? ResponseObject() => typeof(GenerateCredentialsResultModel);

    public override string? UriSuffix() => "/generateCredentials";


}