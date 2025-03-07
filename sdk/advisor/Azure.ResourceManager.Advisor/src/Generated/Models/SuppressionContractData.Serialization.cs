// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor
{
    public partial class SuppressionContractData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(SuppressionId))
            {
                writer.WritePropertyName("suppressionId");
                writer.WriteStringValue(SuppressionId);
            }
            if (Optional.IsDefined(Ttl))
            {
                writer.WritePropertyName("ttl");
                writer.WriteStringValue(Ttl);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SuppressionContractData DeserializeSuppressionContractData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> suppressionId = default;
            Optional<string> ttl = default;
            Optional<DateTimeOffset> expirationTimeStamp = default;
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
                        if (property0.NameEquals("suppressionId"))
                        {
                            suppressionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ttl"))
                        {
                            ttl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expirationTimeStamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expirationTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SuppressionContractData(id, name, type, systemData.Value, suppressionId.Value, ttl.Value, Optional.ToNullable(expirationTimeStamp));
        }
    }
}
