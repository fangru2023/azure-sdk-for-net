// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class ResourceAssociation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AccessMode))
            {
                writer.WritePropertyName("accessMode"u8);
                writer.WriteStringValue(AccessMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ResourceAssociation DeserializeResourceAssociation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<NetworkSecurityPerimeterAssociationAccessMode> accessMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessMode = new NetworkSecurityPerimeterAssociationAccessMode(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceAssociation(name.Value, Optional.ToNullable(accessMode));
        }
    }
}
