// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class GroupConnectivityInformation : IUtf8JsonSerializable, IJsonModel<GroupConnectivityInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GroupConnectivityInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GroupConnectivityInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupConnectivityInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupConnectivityInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && GroupId != null)
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (options.Format != "W" && MemberName != null)
            {
                writer.WritePropertyName("memberName"u8);
                writer.WriteStringValue(MemberName);
            }
            if (!(CustomerVisibleFqdns is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("customerVisibleFqdns"u8);
                writer.WriteStartArray();
                foreach (var item in CustomerVisibleFqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && InternalFqdn != null)
            {
                writer.WritePropertyName("internalFqdn"u8);
                writer.WriteStringValue(InternalFqdn);
            }
            if (RedirectMapId != null)
            {
                writer.WritePropertyName("redirectMapId"u8);
                writer.WriteStringValue(RedirectMapId);
            }
            if (PrivateLinkServiceArmRegion.HasValue)
            {
                writer.WritePropertyName("privateLinkServiceArmRegion"u8);
                writer.WriteStringValue(PrivateLinkServiceArmRegion.Value);
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

        GroupConnectivityInformation IJsonModel<GroupConnectivityInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupConnectivityInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupConnectivityInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGroupConnectivityInformation(document.RootElement, options);
        }

        internal static GroupConnectivityInformation DeserializeGroupConnectivityInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string groupId = default;
            string memberName = default;
            IList<string> customerVisibleFqdns = default;
            string internalFqdn = default;
            string redirectMapId = default;
            AzureLocation? privateLinkServiceArmRegion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memberName"u8))
                {
                    memberName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customerVisibleFqdns"u8))
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
                    customerVisibleFqdns = array;
                    continue;
                }
                if (property.NameEquals("internalFqdn"u8))
                {
                    internalFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("redirectMapId"u8))
                {
                    redirectMapId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkServiceArmRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceArmRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GroupConnectivityInformation(
                groupId,
                memberName,
                customerVisibleFqdns ?? new ChangeTrackingList<string>(),
                internalFqdn,
                redirectMapId,
                privateLinkServiceArmRegion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GroupConnectivityInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupConnectivityInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GroupConnectivityInformation)} does not support '{options.Format}' format.");
            }
        }

        GroupConnectivityInformation IPersistableModel<GroupConnectivityInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupConnectivityInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGroupConnectivityInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GroupConnectivityInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GroupConnectivityInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
