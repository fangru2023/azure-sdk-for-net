// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBMetricDefinitionsListResult
    {
        internal static CosmosDBMetricDefinitionsListResult DeserializeCosmosDBMetricDefinitionsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CosmosDBMetricDefinition>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CosmosDBMetricDefinition> array = new List<CosmosDBMetricDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBMetricDefinition.DeserializeCosmosDBMetricDefinition(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBMetricDefinitionsListResult(Optional.ToList(value));
        }
    }
}
