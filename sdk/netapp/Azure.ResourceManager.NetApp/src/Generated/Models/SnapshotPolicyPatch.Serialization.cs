// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class SnapshotPolicyPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule");
                writer.WriteObjectValue(HourlySchedule);
            }
            if (Optional.IsDefined(DailySchedule))
            {
                writer.WritePropertyName("dailySchedule");
                writer.WriteObjectValue(DailySchedule);
            }
            if (Optional.IsDefined(WeeklySchedule))
            {
                writer.WritePropertyName("weeklySchedule");
                writer.WriteObjectValue(WeeklySchedule);
            }
            if (Optional.IsDefined(MonthlySchedule))
            {
                writer.WritePropertyName("monthlySchedule");
                writer.WriteObjectValue(MonthlySchedule);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
