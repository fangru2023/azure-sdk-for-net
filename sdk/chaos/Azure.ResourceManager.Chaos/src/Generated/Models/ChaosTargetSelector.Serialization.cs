// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ChaosTargetSelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SelectorType.ToString());
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        internal static ChaosTargetSelector DeserializeChaosTargetSelector(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "List": return ChaosTargetListSelector.DeserializeChaosTargetListSelector(element);
                    case "Query": return ChaosTargetQuerySelector.DeserializeChaosTargetQuerySelector(element);
                }
            }
            return UnknownChaosTargetSelector.DeserializeUnknownChaosTargetSelector(element);
        }
    }
}
