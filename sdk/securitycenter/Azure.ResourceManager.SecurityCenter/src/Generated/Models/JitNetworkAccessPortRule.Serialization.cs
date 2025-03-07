// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessPortRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("number");
            writer.WriteNumberValue(Number);
            writer.WritePropertyName("protocol");
            writer.WriteStringValue(Protocol.ToString());
            if (Optional.IsDefined(AllowedSourceAddressPrefix))
            {
                writer.WritePropertyName("allowedSourceAddressPrefix");
                writer.WriteStringValue(AllowedSourceAddressPrefix);
            }
            if (Optional.IsCollectionDefined(AllowedSourceAddressPrefixes))
            {
                writer.WritePropertyName("allowedSourceAddressPrefixes");
                writer.WriteStartArray();
                foreach (var item in AllowedSourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("maxRequestAccessDuration");
            writer.WriteStringValue(MaxRequestAccessDuration, "P");
            writer.WriteEndObject();
        }

        internal static JitNetworkAccessPortRule DeserializeJitNetworkAccessPortRule(JsonElement element)
        {
            int number = default;
            Protocol protocol = default;
            Optional<string> allowedSourceAddressPrefix = default;
            Optional<IList<string>> allowedSourceAddressPrefixes = default;
            TimeSpan maxRequestAccessDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("number"))
                {
                    number = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    protocol = new Protocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefix"))
                {
                    allowedSourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefixes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedSourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("maxRequestAccessDuration"))
                {
                    maxRequestAccessDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new JitNetworkAccessPortRule(number, protocol, allowedSourceAddressPrefix.Value, Optional.ToList(allowedSourceAddressPrefixes), maxRequestAccessDuration);
        }
    }
}
