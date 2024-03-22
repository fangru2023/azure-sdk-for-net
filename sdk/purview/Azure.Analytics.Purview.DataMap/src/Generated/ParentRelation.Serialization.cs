// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class ParentRelation : IUtf8JsonSerializable, IJsonModel<ParentRelation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ParentRelation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ParentRelation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParentRelation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParentRelation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ChildEntityId))
            {
                writer.WritePropertyName("childEntityId"u8);
                writer.WriteStringValue(ChildEntityId);
            }
            if (Optional.IsDefined(RelationshipId))
            {
                writer.WritePropertyName("relationshipId"u8);
                writer.WriteStringValue(RelationshipId);
            }
            if (Optional.IsDefined(ParentEntityId))
            {
                writer.WritePropertyName("parentEntityId"u8);
                writer.WriteStringValue(ParentEntityId);
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

        ParentRelation IJsonModel<ParentRelation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParentRelation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParentRelation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeParentRelation(document.RootElement, options);
        }

        internal static ParentRelation DeserializeParentRelation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string childEntityId = default;
            string relationshipId = default;
            string parentEntityId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("childEntityId"u8))
                {
                    childEntityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relationshipId"u8))
                {
                    relationshipId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentEntityId"u8))
                {
                    parentEntityId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ParentRelation(childEntityId, relationshipId, parentEntityId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ParentRelation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParentRelation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ParentRelation)} does not support writing '{options.Format}' format.");
            }
        }

        ParentRelation IPersistableModel<ParentRelation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParentRelation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeParentRelation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ParentRelation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ParentRelation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ParentRelation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeParentRelation(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
