// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Relay.Models
{
    public partial class RelaySku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name.ToString());
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static RelaySku DeserializeRelaySku(JsonElement element)
        {
            RelaySkuName name = default;
            Optional<RelaySkuTier> tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new RelaySkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tier = new RelaySkuTier(property.Value.GetString());
                    continue;
                }
            }
            return new RelaySku(name, Optional.ToNullable(tier));
        }
    }
}
