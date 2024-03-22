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
    public partial class SsisPackage : IUtf8JsonSerializable, IJsonModel<SsisPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SsisPackage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SsisPackage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisPackage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FolderId))
            {
                writer.WritePropertyName("folderId"u8);
                writer.WriteNumberValue(FolderId.Value);
            }
            if (Optional.IsDefined(ProjectVersion))
            {
                writer.WritePropertyName("projectVersion"u8);
                writer.WriteNumberValue(ProjectVersion.Value);
            }
            if (Optional.IsDefined(ProjectId))
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteNumberValue(ProjectId.Value);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(MetadataType.ToString());
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        SsisPackage IJsonModel<SsisPackage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisPackage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisPackage(document.RootElement, options);
        }

        internal static SsisPackage DeserializeSsisPackage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? folderId = default;
            long? projectVersion = default;
            long? projectId = default;
            IReadOnlyList<SsisParameterInfo> parameters = default;
            SsisObjectMetadataType type = default;
            long? id = default;
            string name = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectVersion = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SsisParameterInfo> array = new List<SsisParameterInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SsisParameterInfo.DeserializeSsisParameterInfo(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SsisPackage(
                type,
                id,
                name,
                description,
                serializedAdditionalRawData,
                folderId,
                projectVersion,
                projectId,
                parameters ?? new ChangeTrackingList<SsisParameterInfo>());
        }

        BinaryData IPersistableModel<SsisPackage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SsisPackage)} does not support writing '{options.Format}' format.");
            }
        }

        SsisPackage IPersistableModel<SsisPackage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSsisPackage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SsisPackage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SsisPackage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
