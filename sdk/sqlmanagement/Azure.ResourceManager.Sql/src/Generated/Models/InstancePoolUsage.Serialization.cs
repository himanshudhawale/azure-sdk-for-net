// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class InstancePoolUsage
    {
        internal static InstancePoolUsage DeserializeInstancePoolUsage(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            Optional<InstancePoolUsageName> name = default;
            Optional<ResourceType> type = default;
            Optional<string> unit = default;
            Optional<int> currentValue = default;
            Optional<int> limit = default;
            Optional<int> requestedLimit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = InstancePoolUsageName.DeserializeInstancePoolUsageName(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("requestedLimit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestedLimit = property.Value.GetInt32();
                    continue;
                }
            }
            return new InstancePoolUsage(id.Value, name.Value, Optional.ToNullable(type), unit.Value, Optional.ToNullable(currentValue), Optional.ToNullable(limit), Optional.ToNullable(requestedLimit));
        }
    }
}
