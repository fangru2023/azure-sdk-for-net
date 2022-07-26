// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterManagedOutboundIPProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterManagedOutboundIPProfile DeserializeManagedClusterManagedOutboundIPProfile(JsonElement element)
        {
            Optional<int> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
            }
            return new ManagedClusterManagedOutboundIPProfile(Optional.ToNullable(count));
        }
    }
}
