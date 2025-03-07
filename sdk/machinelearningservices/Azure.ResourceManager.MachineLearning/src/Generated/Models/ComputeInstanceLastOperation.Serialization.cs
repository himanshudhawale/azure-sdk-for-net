// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ComputeInstanceLastOperation
    {
        internal static ComputeInstanceLastOperation DeserializeComputeInstanceLastOperation(JsonElement element)
        {
            Optional<OperationName> operationName = default;
            Optional<DateTimeOffset> operationTime = default;
            Optional<OperationStatus> operationStatus = default;
            Optional<OperationTrigger> operationTrigger = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operationName = new OperationName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("operationStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operationStatus = new OperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationTrigger"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operationTrigger = new OperationTrigger(property.Value.GetString());
                    continue;
                }
            }
            return new ComputeInstanceLastOperation(Optional.ToNullable(operationName), Optional.ToNullable(operationTime), Optional.ToNullable(operationStatus), Optional.ToNullable(operationTrigger));
        }
    }
}
