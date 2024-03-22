// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class OnYourDataSystemAssignedManagedIdentityAuthenticationOptions : IUtf8JsonSerializable, IJsonModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataSystemAssignedManagedIdentityAuthenticationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        OnYourDataSystemAssignedManagedIdentityAuthenticationOptions IJsonModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataSystemAssignedManagedIdentityAuthenticationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnYourDataSystemAssignedManagedIdentityAuthenticationOptions(document.RootElement, options);
        }

        internal static OnYourDataSystemAssignedManagedIdentityAuthenticationOptions DeserializeOnYourDataSystemAssignedManagedIdentityAuthenticationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OnYourDataAuthenticationType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new OnYourDataAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OnYourDataSystemAssignedManagedIdentityAuthenticationOptions(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OnYourDataSystemAssignedManagedIdentityAuthenticationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        OnYourDataSystemAssignedManagedIdentityAuthenticationOptions IPersistableModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOnYourDataSystemAssignedManagedIdentityAuthenticationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OnYourDataSystemAssignedManagedIdentityAuthenticationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OnYourDataSystemAssignedManagedIdentityAuthenticationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new OnYourDataSystemAssignedManagedIdentityAuthenticationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOnYourDataSystemAssignedManagedIdentityAuthenticationOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
