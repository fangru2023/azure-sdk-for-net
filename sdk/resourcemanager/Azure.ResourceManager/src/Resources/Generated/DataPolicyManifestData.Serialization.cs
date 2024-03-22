// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class DataPolicyManifestData : IUtf8JsonSerializable, IJsonModel<DataPolicyManifestData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataPolicyManifestData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataPolicyManifestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPolicyManifestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataPolicyManifestData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Namespaces))
            {
                writer.WritePropertyName("namespaces"u8);
                writer.WriteStartArray();
                foreach (var item in Namespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyMode))
            {
                writer.WritePropertyName("policyMode"u8);
                writer.WriteStringValue(PolicyMode);
            }
            if (Optional.IsDefined(IsBuiltInOnly))
            {
                writer.WritePropertyName("isBuiltInOnly"u8);
                writer.WriteBooleanValue(IsBuiltInOnly.Value);
            }
            if (Optional.IsCollectionDefined(ResourceTypeAliases))
            {
                writer.WritePropertyName("resourceTypeAliases"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypeAliases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Effects))
            {
                writer.WritePropertyName("effects"u8);
                writer.WriteStartArray();
                foreach (var item in Effects)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FieldValues))
            {
                writer.WritePropertyName("fieldValues"u8);
                writer.WriteStartArray();
                foreach (var item in FieldValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("resourceFunctions"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Standard))
            {
                writer.WritePropertyName("standard"u8);
                writer.WriteStartArray();
                foreach (var item in Standard)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomDefinitions))
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
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

        DataPolicyManifestData IJsonModel<DataPolicyManifestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPolicyManifestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataPolicyManifestData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataPolicyManifestData(document.RootElement, options);
        }

        internal static DataPolicyManifestData DeserializeDataPolicyManifestData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyList<string> namespaces = default;
            string policyMode = default;
            bool? isBuiltInOnly = default;
            IReadOnlyList<ResourceTypeAliases> resourceTypeAliases = default;
            IReadOnlyList<DataPolicyManifestEffect> effects = default;
            IReadOnlyList<string> fieldValues = default;
            IReadOnlyList<string> standard = default;
            IReadOnlyList<DataManifestCustomResourceFunctionDefinition> custom = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("namespaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            namespaces = array;
                            continue;
                        }
                        if (property0.NameEquals("policyMode"u8))
                        {
                            policyMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isBuiltInOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isBuiltInOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("resourceTypeAliases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceTypeAliases> array = new List<ResourceTypeAliases>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.ResourceTypeAliases.DeserializeResourceTypeAliases(item, options));
                            }
                            resourceTypeAliases = array;
                            continue;
                        }
                        if (property0.NameEquals("effects"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataPolicyManifestEffect> array = new List<DataPolicyManifestEffect>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataPolicyManifestEffect.DeserializeDataPolicyManifestEffect(item, options));
                            }
                            effects = array;
                            continue;
                        }
                        if (property0.NameEquals("fieldValues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            fieldValues = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceFunctions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("standard"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<string> array = new List<string>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(item.GetString());
                                    }
                                    standard = array;
                                    continue;
                                }
                                if (property1.NameEquals("custom"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<DataManifestCustomResourceFunctionDefinition> array = new List<DataManifestCustomResourceFunctionDefinition>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(DataManifestCustomResourceFunctionDefinition.DeserializeDataManifestCustomResourceFunctionDefinition(item, options));
                                    }
                                    custom = array;
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataPolicyManifestData(
                id,
                name,
                type,
                systemData,
                namespaces ?? new ChangeTrackingList<string>(),
                policyMode,
                isBuiltInOnly,
                resourceTypeAliases ?? new ChangeTrackingList<ResourceTypeAliases>(),
                effects ?? new ChangeTrackingList<DataPolicyManifestEffect>(),
                fieldValues ?? new ChangeTrackingList<string>(),
                standard ?? new ChangeTrackingList<string>(),
                custom ?? new ChangeTrackingList<DataManifestCustomResourceFunctionDefinition>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataPolicyManifestData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPolicyManifestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataPolicyManifestData)} does not support writing '{options.Format}' format.");
            }
        }

        DataPolicyManifestData IPersistableModel<DataPolicyManifestData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPolicyManifestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataPolicyManifestData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataPolicyManifestData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataPolicyManifestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
