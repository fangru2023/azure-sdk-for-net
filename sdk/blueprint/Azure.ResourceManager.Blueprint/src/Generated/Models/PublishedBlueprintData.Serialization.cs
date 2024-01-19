// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Blueprint.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint
{
    public partial class PublishedBlueprintData : IUtf8JsonSerializable, IJsonModel<PublishedBlueprintData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublishedBlueprintData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PublishedBlueprintData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishedBlueprintData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublishedBlueprintData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (Optional.IsDefined(TargetScope))
            {
                writer.WritePropertyName("targetScope"u8);
                writer.WriteStringValue(TargetScope.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ResourceGroups))
            {
                writer.WritePropertyName("resourceGroups"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceGroups)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(BlueprintName))
            {
                writer.WritePropertyName("blueprintName"u8);
                writer.WriteStringValue(BlueprintName);
            }
            if (Optional.IsDefined(ChangeNotes))
            {
                writer.WritePropertyName("changeNotes"u8);
                writer.WriteStringValue(ChangeNotes);
            }
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

        PublishedBlueprintData IJsonModel<PublishedBlueprintData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishedBlueprintData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublishedBlueprintData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublishedBlueprintData(document.RootElement, options);
        }

        internal static PublishedBlueprintData DeserializePublishedBlueprintData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<BlueprintStatus> status = default;
            Optional<BlueprintTargetScope> targetScope = default;
            Optional<IDictionary<string, ParameterDefinition>> parameters = default;
            Optional<IDictionary<string, ResourceGroupDefinition>> resourceGroups = default;
            Optional<string> blueprintName = default;
            Optional<string> changeNotes = default;
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = BlueprintStatus.DeserializeBlueprintStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetScope = new BlueprintTargetScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ParameterDefinition> dictionary = new Dictionary<string, ParameterDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ParameterDefinition.DeserializeParameterDefinition(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("resourceGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ResourceGroupDefinition> dictionary = new Dictionary<string, ResourceGroupDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ResourceGroupDefinition.DeserializeResourceGroupDefinition(property1.Value));
                            }
                            resourceGroups = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("blueprintName"u8))
                        {
                            blueprintName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("changeNotes"u8))
                        {
                            changeNotes = property0.Value.GetString();
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
            return new PublishedBlueprintData(id, name, type, systemData.Value, displayName.Value, description.Value, status.Value, Optional.ToNullable(targetScope), Optional.ToDictionary(parameters), Optional.ToDictionary(resourceGroups), blueprintName.Value, changeNotes.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PublishedBlueprintData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishedBlueprintData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PublishedBlueprintData)} does not support '{options.Format}' format.");
            }
        }

        PublishedBlueprintData IPersistableModel<PublishedBlueprintData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishedBlueprintData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePublishedBlueprintData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PublishedBlueprintData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublishedBlueprintData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
