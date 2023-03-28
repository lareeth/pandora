using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2020_10_01.ActivityLogAlertsAPIs;


internal class AlertRulePropertiesModel
{
    [JsonPropertyName("actions")]
    [Required]
    public ActionListModel Actions { get; set; }

    [JsonPropertyName("condition")]
    [Required]
    public AlertRuleAllOfConditionModel Condition { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("scopes")]
    [Required]
    public List<string> Scopes { get; set; }
}