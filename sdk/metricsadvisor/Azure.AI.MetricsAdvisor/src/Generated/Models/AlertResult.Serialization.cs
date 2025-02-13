// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class AlertResult
    {
        internal static AlertResult DeserializeAlertResult(JsonElement element)
        {
            Optional<string> alertId = default;
            DateTimeOffset timestamp = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset modifiedTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertId"))
                {
                    alertId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedTime"))
                {
                    modifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AlertResult(alertId.Value, timestamp, createdTime, modifiedTime);
        }
    }
}
