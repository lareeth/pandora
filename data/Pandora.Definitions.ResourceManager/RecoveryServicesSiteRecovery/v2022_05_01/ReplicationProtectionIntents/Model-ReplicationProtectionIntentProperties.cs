using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2022_05_01.ReplicationProtectionIntents;


internal class ReplicationProtectionIntentPropertiesModel
{
    [JsonPropertyName("creationTimeUTC")]
    public string? CreationTimeUTC { get; set; }

    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    [JsonPropertyName("jobState")]
    public string? JobState { get; set; }

    [JsonPropertyName("providerSpecificDetails")]
    public ReplicationProtectionIntentProviderSpecificSettingsModel? ProviderSpecificDetails { get; set; }
}