// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class KubernetesPVRestoreCriteria : IUtf8JsonSerializable, IJsonModel<KubernetesPVRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesPVRestoreCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesPVRestoreCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPVRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesPVRestoreCriteria)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(StorageClassName))
            {
                writer.WritePropertyName("storageClassName"u8);
                writer.WriteStringValue(StorageClassName);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        KubernetesPVRestoreCriteria IJsonModel<KubernetesPVRestoreCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPVRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesPVRestoreCriteria)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesPVRestoreCriteria(document.RootElement, options);
        }

        internal static KubernetesPVRestoreCriteria DeserializeKubernetesPVRestoreCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string storageClassName = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageClassName"u8))
                {
                    storageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesPVRestoreCriteria(objectType, serializedAdditionalRawData, name, storageClassName);
        }

        BinaryData IPersistableModel<KubernetesPVRestoreCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPVRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesPVRestoreCriteria)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesPVRestoreCriteria IPersistableModel<KubernetesPVRestoreCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPVRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesPVRestoreCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesPVRestoreCriteria)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesPVRestoreCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
