// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusImageArtifactProfile : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusImageArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusImageArtifactProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureOperatorNexusImageArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImageArtifactProfile))
            {
                writer.WritePropertyName("imageArtifactProfile"u8);
                writer.WriteObjectValue(ImageArtifactProfile);
            }
            if (Optional.IsDefined(ArtifactStore))
            {
                writer.WritePropertyName("artifactStore"u8);
                JsonSerializer.Serialize(writer, ArtifactStore);
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

        AzureOperatorNexusImageArtifactProfile IJsonModel<AzureOperatorNexusImageArtifactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusImageArtifactProfile(document.RootElement, options);
        }

        internal static AzureOperatorNexusImageArtifactProfile DeserializeAzureOperatorNexusImageArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageArtifactProfile imageArtifactProfile = default;
            WritableSubResource artifactStore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageArtifactProfile = ImageArtifactProfile.DeserializeImageArtifactProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("artifactStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactStore = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureOperatorNexusImageArtifactProfile(artifactStore, serializedAdditionalRawData, imageArtifactProfile);
        }

        BinaryData IPersistableModel<AzureOperatorNexusImageArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AzureOperatorNexusImageArtifactProfile IPersistableModel<AzureOperatorNexusImageArtifactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureOperatorNexusImageArtifactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusImageArtifactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
