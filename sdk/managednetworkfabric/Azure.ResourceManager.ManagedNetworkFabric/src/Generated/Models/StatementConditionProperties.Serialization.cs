// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class StatementConditionProperties : IUtf8JsonSerializable, IJsonModel<StatementConditionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StatementConditionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StatementConditionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementConditionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatementConditionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RoutePolicyConditionType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RoutePolicyConditionType.Value.ToString());
            }
            if (IPPrefixId != null)
            {
                writer.WritePropertyName("ipPrefixId"u8);
                writer.WriteStringValue(IPPrefixId);
            }
            if (!(IPExtendedCommunityIds is ChangeTrackingList<ResourceIdentifier> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ipExtendedCommunityIds"u8);
                writer.WriteStartArray();
                foreach (var item in IPExtendedCommunityIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(IPCommunityIds is ChangeTrackingList<ResourceIdentifier> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("ipCommunityIds"u8);
                writer.WriteStartArray();
                foreach (var item in IPCommunityIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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

        StatementConditionProperties IJsonModel<StatementConditionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementConditionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatementConditionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStatementConditionProperties(document.RootElement, options);
        }

        internal static StatementConditionProperties DeserializeStatementConditionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RoutePolicyConditionType? type = default;
            ResourceIdentifier ipPrefixId = default;
            IList<ResourceIdentifier> ipExtendedCommunityIds = default;
            IList<ResourceIdentifier> ipCommunityIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RoutePolicyConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipPrefixId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipPrefixId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipExtendedCommunityIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    ipExtendedCommunityIds = array;
                    continue;
                }
                if (property.NameEquals("ipCommunityIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    ipCommunityIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StatementConditionProperties(ipCommunityIds ?? new ChangeTrackingList<ResourceIdentifier>(), serializedAdditionalRawData, type, ipPrefixId, ipExtendedCommunityIds ?? new ChangeTrackingList<ResourceIdentifier>());
        }

        BinaryData IPersistableModel<StatementConditionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementConditionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StatementConditionProperties)} does not support '{options.Format}' format.");
            }
        }

        StatementConditionProperties IPersistableModel<StatementConditionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementConditionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStatementConditionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StatementConditionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StatementConditionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
