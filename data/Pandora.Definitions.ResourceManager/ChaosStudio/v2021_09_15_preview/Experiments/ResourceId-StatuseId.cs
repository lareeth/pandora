using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2021_09_15_preview.Experiments;

internal class StatuseId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/statuses/{statusId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftChaos", "Microsoft.Chaos"),
        ResourceIDSegment.Static("staticExperiments", "experiments"),
        ResourceIDSegment.UserSpecified("experimentName"),
        ResourceIDSegment.Static("staticStatuses", "statuses"),
        ResourceIDSegment.UserSpecified("statusId"),
    };
}
