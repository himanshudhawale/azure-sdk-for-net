// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class Balance
    {
        internal static Balance DeserializeBalance(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> currency = default;
            Optional<decimal> beginningBalance = default;
            Optional<decimal> endingBalance = default;
            Optional<decimal> newPurchases = default;
            Optional<decimal> adjustments = default;
            Optional<decimal> utilized = default;
            Optional<decimal> serviceOverage = default;
            Optional<decimal> chargesBilledSeparately = default;
            Optional<decimal> totalOverage = default;
            Optional<decimal> totalUsage = default;
            Optional<decimal> azureMarketplaceServiceCharges = default;
            Optional<BillingFrequency> billingFrequency = default;
            Optional<bool> priceHidden = default;
            Optional<IReadOnlyList<BalancePropertiesNewPurchasesDetailsItem>> newPurchasesDetails = default;
            Optional<IReadOnlyList<BalancePropertiesAdjustmentDetailsItem>> adjustmentDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
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
                        if (property0.NameEquals("currency"))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("beginningBalance"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            beginningBalance = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("endingBalance"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endingBalance = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("newPurchases"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newPurchases = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("adjustments"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            adjustments = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("utilized"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            utilized = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("serviceOverage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serviceOverage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("chargesBilledSeparately"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            chargesBilledSeparately = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("totalOverage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalOverage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("totalUsage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalUsage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("azureMarketplaceServiceCharges"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureMarketplaceServiceCharges = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("billingFrequency"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingFrequency = new BillingFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priceHidden"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            priceHidden = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("newPurchasesDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<BalancePropertiesNewPurchasesDetailsItem> array = new List<BalancePropertiesNewPurchasesDetailsItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BalancePropertiesNewPurchasesDetailsItem.DeserializeBalancePropertiesNewPurchasesDetailsItem(item));
                            }
                            newPurchasesDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("adjustmentDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<BalancePropertiesAdjustmentDetailsItem> array = new List<BalancePropertiesAdjustmentDetailsItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BalancePropertiesAdjustmentDetailsItem.DeserializeBalancePropertiesAdjustmentDetailsItem(item));
                            }
                            adjustmentDetails = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Balance(id, name, type, systemData.Value, currency.Value, Optional.ToNullable(beginningBalance), Optional.ToNullable(endingBalance), Optional.ToNullable(newPurchases), Optional.ToNullable(adjustments), Optional.ToNullable(utilized), Optional.ToNullable(serviceOverage), Optional.ToNullable(chargesBilledSeparately), Optional.ToNullable(totalOverage), Optional.ToNullable(totalUsage), Optional.ToNullable(azureMarketplaceServiceCharges), Optional.ToNullable(billingFrequency), Optional.ToNullable(priceHidden), Optional.ToList(newPurchasesDetails), Optional.ToList(adjustmentDetails), Optional.ToNullable(etag), Optional.ToDictionary(tags));
        }
    }
}
