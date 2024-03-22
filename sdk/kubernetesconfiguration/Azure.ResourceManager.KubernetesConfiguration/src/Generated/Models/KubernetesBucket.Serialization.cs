// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesBucket : IUtf8JsonSerializable, IJsonModel<KubernetesBucket>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesBucket>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesBucket>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesBucket>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesBucket)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(BucketName))
            {
                writer.WritePropertyName("bucketName"u8);
                writer.WriteStringValue(BucketName);
            }
            if (Optional.IsDefined(UseInsecureCommunication))
            {
                writer.WritePropertyName("insecure"u8);
                writer.WriteBooleanValue(UseInsecureCommunication.Value);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(AccessKey))
            {
                if (AccessKey != null)
                {
                    writer.WritePropertyName("accessKey"u8);
                    writer.WriteStringValue(AccessKey);
                }
                else
                {
                    writer.WriteNull("accessKey");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef"u8);
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
                }
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

        KubernetesBucket IJsonModel<KubernetesBucket>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesBucket>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesBucket)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesBucket(document.RootElement, options);
        }

        internal static KubernetesBucket DeserializeKubernetesBucket(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri url = default;
            string bucketName = default;
            bool? insecure = default;
            long? timeoutInSeconds = default;
            long? syncIntervalInSeconds = default;
            string accessKey = default;
            string localAuthRef = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bucketName"u8))
                {
                    bucketName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("insecure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    insecure = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("accessKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessKey = null;
                        continue;
                    }
                    accessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localAuthRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        localAuthRef = null;
                        continue;
                    }
                    localAuthRef = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesBucket(
                url,
                bucketName,
                insecure,
                timeoutInSeconds,
                syncIntervalInSeconds,
                accessKey,
                localAuthRef,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesBucket>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesBucket>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesBucket)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesBucket IPersistableModel<KubernetesBucket>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesBucket>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesBucket(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesBucket)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesBucket>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
