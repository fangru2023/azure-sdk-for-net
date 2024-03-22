// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchNetworkSecurityGroupRule : IUtf8JsonSerializable, IJsonModel<BatchNetworkSecurityGroupRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchNetworkSecurityGroupRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchNetworkSecurityGroupRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkSecurityGroupRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNetworkSecurityGroupRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("access"u8);
            writer.WriteStringValue(Access.ToSerialString());
            writer.WritePropertyName("sourceAddressPrefix"u8);
            writer.WriteStringValue(SourceAddressPrefix);
            if (Optional.IsCollectionDefined(SourcePortRanges))
            {
                writer.WritePropertyName("sourcePortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePortRanges)
                {
                    writer.WriteStringValue(item);
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

        BatchNetworkSecurityGroupRule IJsonModel<BatchNetworkSecurityGroupRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkSecurityGroupRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNetworkSecurityGroupRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchNetworkSecurityGroupRule(document.RootElement, options);
        }

        internal static BatchNetworkSecurityGroupRule DeserializeBatchNetworkSecurityGroupRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int priority = default;
            BatchNetworkSecurityGroupRuleAccess access = default;
            string sourceAddressPrefix = default;
            IList<string> sourcePortRanges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("access"u8))
                {
                    access = property.Value.GetString().ToBatchNetworkSecurityGroupRuleAccess();
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefix"u8))
                {
                    sourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePortRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourcePortRanges = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchNetworkSecurityGroupRule(priority, access, sourceAddressPrefix, sourcePortRanges ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchNetworkSecurityGroupRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkSecurityGroupRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchNetworkSecurityGroupRule)} does not support writing '{options.Format}' format.");
            }
        }

        BatchNetworkSecurityGroupRule IPersistableModel<BatchNetworkSecurityGroupRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkSecurityGroupRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchNetworkSecurityGroupRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchNetworkSecurityGroupRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchNetworkSecurityGroupRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
