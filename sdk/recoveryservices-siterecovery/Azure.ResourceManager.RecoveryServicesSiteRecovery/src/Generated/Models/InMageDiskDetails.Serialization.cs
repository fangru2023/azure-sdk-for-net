// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageDiskDetails : IUtf8JsonSerializable, IJsonModel<InMageDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DiskId != null)
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (DiskName != null)
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (DiskSizeInMB != null)
            {
                writer.WritePropertyName("diskSizeInMB"u8);
                writer.WriteStringValue(DiskSizeInMB);
            }
            if (DiskType != null)
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType);
            }
            if (DiskConfiguration != null)
            {
                writer.WritePropertyName("diskConfiguration"u8);
                writer.WriteStringValue(DiskConfiguration);
            }
            if (!(VolumeList is ChangeTrackingList<SiteRecoveryDiskVolumeDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("volumeList"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeList)
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

        InMageDiskDetails IJsonModel<InMageDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageDiskDetails(document.RootElement, options);
        }

        internal static InMageDiskDetails DeserializeInMageDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            string diskName = default;
            string diskSizeInMB = default;
            string diskType = default;
            string diskConfiguration = default;
            IReadOnlyList<SiteRecoveryDiskVolumeDetails> volumeList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeInMB"u8))
                {
                    diskSizeInMB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    diskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskConfiguration"u8))
                {
                    diskConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("volumeList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDiskVolumeDetails> array = new List<SiteRecoveryDiskVolumeDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDiskVolumeDetails.DeserializeSiteRecoveryDiskVolumeDetails(item, options));
                    }
                    volumeList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageDiskDetails(
                diskId,
                diskName,
                diskSizeInMB,
                diskType,
                diskConfiguration,
                volumeList ?? new ChangeTrackingList<SiteRecoveryDiskVolumeDetails>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageDiskDetails IPersistableModel<InMageDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
