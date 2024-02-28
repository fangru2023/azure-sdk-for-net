// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerRegistryImageDeletedEventDataConverter))]
    public partial class ContainerRegistryImageDeletedEventData
    {
        internal static ContainerRegistryImageDeletedEventData DeserializeContainerRegistryImageDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            DateTimeOffset? timestamp = default;
            string action = default;
            string location = default;
            ContainerRegistryEventTarget target = default;
            ContainerRegistryEventRequest request = default;
            ContainerRegistryEventActor actor = default;
            ContainerRegistryEventSource source = default;
            ContainerRegistryEventConnectedRegistry connectedRegistry = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = ContainerRegistryEventTarget.DeserializeContainerRegistryEventTarget(property.Value);
                    continue;
                }
                if (property.NameEquals("request"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    request = ContainerRegistryEventRequest.DeserializeContainerRegistryEventRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("actor"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actor = ContainerRegistryEventActor.DeserializeContainerRegistryEventActor(property.Value);
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = ContainerRegistryEventSource.DeserializeContainerRegistryEventSource(property.Value);
                    continue;
                }
                if (property.NameEquals("connectedRegistry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedRegistry = ContainerRegistryEventConnectedRegistry.DeserializeContainerRegistryEventConnectedRegistry(property.Value);
                    continue;
                }
            }
            return new ContainerRegistryImageDeletedEventData(
                id,
                timestamp,
                action,
                location,
                target,
                request,
                actor,
                source,
                connectedRegistry);
        }

        internal partial class ContainerRegistryImageDeletedEventDataConverter : JsonConverter<ContainerRegistryImageDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerRegistryImageDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ContainerRegistryImageDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerRegistryImageDeletedEventData(document.RootElement);
            }
        }
    }
}
