// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DeleteDataFlowDebugSessionContent : IUtf8JsonSerializable, IJsonModel<DeleteDataFlowDebugSessionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeleteDataFlowDebugSessionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeleteDataFlowDebugSessionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeleteDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeleteDataFlowDebugSessionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SessionId.HasValue)
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
            writer.WriteEndObject();
        }

        DeleteDataFlowDebugSessionContent IJsonModel<DeleteDataFlowDebugSessionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeleteDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeleteDataFlowDebugSessionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeleteDataFlowDebugSessionContent(document.RootElement, options);
        }

        internal static DeleteDataFlowDebugSessionContent DeserializeDeleteDataFlowDebugSessionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? sessionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeleteDataFlowDebugSessionContent(sessionId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeleteDataFlowDebugSessionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeleteDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeleteDataFlowDebugSessionContent)} does not support '{options.Format}' format.");
            }
        }

        DeleteDataFlowDebugSessionContent IPersistableModel<DeleteDataFlowDebugSessionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeleteDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeleteDataFlowDebugSessionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeleteDataFlowDebugSessionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeleteDataFlowDebugSessionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
