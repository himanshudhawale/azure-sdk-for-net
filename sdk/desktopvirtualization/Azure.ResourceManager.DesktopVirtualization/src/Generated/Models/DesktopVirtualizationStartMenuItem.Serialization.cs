// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class DesktopVirtualizationStartMenuItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AppAlias))
            {
                writer.WritePropertyName("appAlias");
                writer.WriteStringValue(AppAlias);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath");
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(CommandLineArguments))
            {
                writer.WritePropertyName("commandLineArguments");
                writer.WriteStringValue(CommandLineArguments);
            }
            if (Optional.IsDefined(IconPath))
            {
                writer.WritePropertyName("iconPath");
                writer.WriteStringValue(IconPath);
            }
            if (Optional.IsDefined(IconIndex))
            {
                writer.WritePropertyName("iconIndex");
                writer.WriteNumberValue(IconIndex.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DesktopVirtualizationStartMenuItem DeserializeDesktopVirtualizationStartMenuItem(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> appAlias = default;
            Optional<string> filePath = default;
            Optional<string> commandLineArguments = default;
            Optional<string> iconPath = default;
            Optional<int> iconIndex = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("appAlias"))
                        {
                            appAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("filePath"))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("commandLineArguments"))
                        {
                            commandLineArguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconPath"))
                        {
                            iconPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconIndex"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            iconIndex = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DesktopVirtualizationStartMenuItem(id, name, type, systemData.Value, appAlias.Value, filePath.Value, commandLineArguments.Value, iconPath.Value, Optional.ToNullable(iconIndex));
        }
    }
}
