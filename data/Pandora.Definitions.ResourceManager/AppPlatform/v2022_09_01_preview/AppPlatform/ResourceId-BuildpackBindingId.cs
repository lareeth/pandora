using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2022_09_01_preview.AppPlatform;

internal class BuildpackBindingId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings/{buildpackBindingName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftAppPlatform", "Microsoft.AppPlatform"),
        ResourceIDSegment.Static("staticSpring", "spring"),
        ResourceIDSegment.UserSpecified("serviceName"),
        ResourceIDSegment.Static("staticBuildServices", "buildServices"),
        ResourceIDSegment.UserSpecified("buildServiceName"),
        ResourceIDSegment.Static("staticBuilders", "builders"),
        ResourceIDSegment.UserSpecified("builderName"),
        ResourceIDSegment.Static("staticBuildpackBindings", "buildpackBindings"),
        ResourceIDSegment.UserSpecified("buildpackBindingName"),
    };
}
