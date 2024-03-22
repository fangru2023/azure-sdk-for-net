// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class RuleManagementEventClaimsDataSource : IUtf8JsonSerializable, IJsonModel<RuleManagementEventClaimsDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuleManagementEventClaimsDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RuleManagementEventClaimsDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventClaimsDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleManagementEventClaimsDataSource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EmailAddress))
            {
                writer.WritePropertyName("emailAddress"u8);
                writer.WriteStringValue(EmailAddress);
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

        RuleManagementEventClaimsDataSource IJsonModel<RuleManagementEventClaimsDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventClaimsDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleManagementEventClaimsDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuleManagementEventClaimsDataSource(document.RootElement, options);
        }

        internal static RuleManagementEventClaimsDataSource DeserializeRuleManagementEventClaimsDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string emailAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("emailAddress"u8))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RuleManagementEventClaimsDataSource(emailAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RuleManagementEventClaimsDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventClaimsDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RuleManagementEventClaimsDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        RuleManagementEventClaimsDataSource IPersistableModel<RuleManagementEventClaimsDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventClaimsDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRuleManagementEventClaimsDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RuleManagementEventClaimsDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RuleManagementEventClaimsDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
