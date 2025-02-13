// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    public partial class OperationDefinitionListResult
    {
        internal static OperationDefinitionListResult DeserializeOperationDefinitionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<OperationDefinition>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<OperationDefinition> array = new List<OperationDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationDefinition.DeserializeOperationDefinition(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new OperationDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
