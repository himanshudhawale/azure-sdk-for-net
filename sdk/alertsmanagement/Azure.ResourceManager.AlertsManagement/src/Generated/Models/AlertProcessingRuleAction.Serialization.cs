// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("actionType");
            writer.WriteStringValue(ActionType.ToString());
            writer.WriteEndObject();
        }

        internal static AlertProcessingRuleAction DeserializeAlertProcessingRuleAction(JsonElement element)
        {
            if (element.TryGetProperty("actionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AddActionGroups": return AlertProcessingRuleAddGroupsAction.DeserializeAlertProcessingRuleAddGroupsAction(element);
                    case "RemoveAllActionGroups": return AlertProcessingRuleRemoveAllGroupsAction.DeserializeAlertProcessingRuleRemoveAllGroupsAction(element);
                }
            }
            AlertProcessingRuleActionType actionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionType"))
                {
                    actionType = new AlertProcessingRuleActionType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAlertProcessingRuleAction(actionType);
        }
    }
}
