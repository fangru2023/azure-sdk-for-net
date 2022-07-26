// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class VersionSpec
    {
        internal static VersionSpec DeserializeVersionSpec(JsonElement element)
        {
            Optional<string> friendlyName = default;
            Optional<string> displayName = default;
            Optional<bool> isDefault = default;
            Optional<IReadOnlyDictionary<string, string>> componentVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefault"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("componentVersions"))
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
                    componentVersions = dictionary;
                    continue;
                }
            }
            return new VersionSpec(friendlyName.Value, displayName.Value, Optional.ToNullable(isDefault), Optional.ToDictionary(componentVersions));
        }
    }
}
