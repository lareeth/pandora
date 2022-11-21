using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabricManagedCluster.v2022_01_01.ManagedClusterVersion;

internal class EnvironmentManagedClusterVersionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/Windows/managedClusterVersions/{clusterVersion}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftServiceFabric", "Microsoft.ServiceFabric"),
        ResourceIDSegment.Static("staticLocations", "locations"),
        ResourceIDSegment.UserSpecified("location"),
        ResourceIDSegment.Static("staticEnvironments", "environments"),
        ResourceIDSegment.Static("environment", "Windows"),
        ResourceIDSegment.Static("staticManagedClusterVersions", "managedClusterVersions"),
        ResourceIDSegment.UserSpecified("clusterVersion"),
    };
}