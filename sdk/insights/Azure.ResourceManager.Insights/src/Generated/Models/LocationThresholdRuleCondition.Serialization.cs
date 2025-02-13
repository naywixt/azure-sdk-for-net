// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class LocationThresholdRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WindowSize))
            {
                writer.WritePropertyName("windowSize");
                writer.WriteStringValue(WindowSize.Value, "P");
            }
            writer.WritePropertyName("failedLocationCount");
            writer.WriteNumberValue(FailedLocationCount);
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource");
                writer.WriteObjectValue(DataSource);
            }
            writer.WriteEndObject();
        }

        internal static LocationThresholdRuleCondition DeserializeLocationThresholdRuleCondition(JsonElement element)
        {
            Optional<TimeSpan> windowSize = default;
            int failedLocationCount = default;
            string odataType = default;
            Optional<RuleDataSource> dataSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("windowSize"))
                {
                    windowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("failedLocationCount"))
                {
                    failedLocationCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"))
                {
                    dataSource = RuleDataSource.DeserializeRuleDataSource(property.Value);
                    continue;
                }
            }
            return new LocationThresholdRuleCondition(odataType, dataSource.Value, Optional.ToNullable(windowSize), failedLocationCount);
        }
    }
}
