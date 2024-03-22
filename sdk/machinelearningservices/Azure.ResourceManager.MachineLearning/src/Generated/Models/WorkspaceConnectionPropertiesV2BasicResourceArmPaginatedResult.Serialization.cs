// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult : IUtf8JsonSerializable, IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(document.RootElement, options);
        }

        internal static WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nextLink = default;
            IReadOnlyList<MachineLearningWorkspaceConnectionData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningWorkspaceConnectionData> array = new List<MachineLearningWorkspaceConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningWorkspaceConnectionData.DeserializeMachineLearningWorkspaceConnectionData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(nextLink, value ?? new ChangeTrackingList<MachineLearningWorkspaceConnectionData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult)} does not support writing '{options.Format}' format.");
            }
        }

        WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
