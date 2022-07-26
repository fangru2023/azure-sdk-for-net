// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterAutoUpgradeProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UpgradeChannel))
            {
                writer.WritePropertyName("upgradeChannel");
                writer.WriteStringValue(UpgradeChannel.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterAutoUpgradeProfile DeserializeManagedClusterAutoUpgradeProfile(JsonElement element)
        {
            Optional<UpgradeChannel> upgradeChannel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("upgradeChannel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    upgradeChannel = new UpgradeChannel(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedClusterAutoUpgradeProfile(Optional.ToNullable(upgradeChannel));
        }
    }
}
