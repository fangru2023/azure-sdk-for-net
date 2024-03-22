// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class OperationalizationClusterCredentials : IUtf8JsonSerializable, IJsonModel<OperationalizationClusterCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalizationClusterCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalizationClusterCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalizationClusterCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalizationClusterCredentials)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccount))
            {
                writer.WritePropertyName("storageAccount"u8);
                writer.WriteObjectValue(StorageAccount);
            }
            if (Optional.IsDefined(ContainerRegistry))
            {
                writer.WritePropertyName("containerRegistry"u8);
                writer.WriteObjectValue(ContainerRegistry);
            }
            if (Optional.IsDefined(ContainerService))
            {
                writer.WritePropertyName("containerService"u8);
                writer.WriteObjectValue(ContainerService);
            }
            if (Optional.IsDefined(AppInsights))
            {
                writer.WritePropertyName("appInsights"u8);
                writer.WriteObjectValue(AppInsights);
            }
            if (Optional.IsDefined(ServiceAuthConfiguration))
            {
                writer.WritePropertyName("serviceAuthConfiguration"u8);
                writer.WriteObjectValue(ServiceAuthConfiguration);
            }
            if (Optional.IsDefined(SslConfiguration))
            {
                writer.WritePropertyName("sslConfiguration"u8);
                writer.WriteObjectValue(SslConfiguration);
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

        OperationalizationClusterCredentials IJsonModel<OperationalizationClusterCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalizationClusterCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalizationClusterCredentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalizationClusterCredentials(document.RootElement, options);
        }

        internal static OperationalizationClusterCredentials DeserializeOperationalizationClusterCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageAccountCredentials storageAccount = default;
            ContainerRegistryCredentials containerRegistry = default;
            ContainerServiceCredentials containerService = default;
            AppInsightsCredentials appInsights = default;
            ServiceAuthConfiguration serviceAuthConfiguration = default;
            SslConfiguration sslConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccount = StorageAccountCredentials.DeserializeStorageAccountCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("containerRegistry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerRegistry = ContainerRegistryCredentials.DeserializeContainerRegistryCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("containerService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerService = ContainerServiceCredentials.DeserializeContainerServiceCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("appInsights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsights = AppInsightsCredentials.DeserializeAppInsightsCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceAuthConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceAuthConfiguration = ServiceAuthConfiguration.DeserializeServiceAuthConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sslConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslConfiguration = SslConfiguration.DeserializeSslConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalizationClusterCredentials(
                storageAccount,
                containerRegistry,
                containerService,
                appInsights,
                serviceAuthConfiguration,
                sslConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalizationClusterCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalizationClusterCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalizationClusterCredentials)} does not support writing '{options.Format}' format.");
            }
        }

        OperationalizationClusterCredentials IPersistableModel<OperationalizationClusterCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalizationClusterCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalizationClusterCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalizationClusterCredentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalizationClusterCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
