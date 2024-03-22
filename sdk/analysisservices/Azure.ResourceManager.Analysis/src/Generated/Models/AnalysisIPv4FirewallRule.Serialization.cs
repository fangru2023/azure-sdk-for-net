// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    public partial class AnalysisIPv4FirewallRule : IUtf8JsonSerializable, IJsonModel<AnalysisIPv4FirewallRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalysisIPv4FirewallRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalysisIPv4FirewallRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisIPv4FirewallRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FirewallRuleName))
            {
                writer.WritePropertyName("firewallRuleName"u8);
                writer.WriteStringValue(FirewallRuleName);
            }
            if (Optional.IsDefined(RangeStart))
            {
                writer.WritePropertyName("rangeStart"u8);
                writer.WriteStringValue(RangeStart);
            }
            if (Optional.IsDefined(RangeEnd))
            {
                writer.WritePropertyName("rangeEnd"u8);
                writer.WriteStringValue(RangeEnd);
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

        AnalysisIPv4FirewallRule IJsonModel<AnalysisIPv4FirewallRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisIPv4FirewallRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalysisIPv4FirewallRule(document.RootElement, options);
        }

        internal static AnalysisIPv4FirewallRule DeserializeAnalysisIPv4FirewallRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string firewallRuleName = default;
            string rangeStart = default;
            string rangeEnd = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firewallRuleName"u8))
                {
                    firewallRuleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rangeStart"u8))
                {
                    rangeStart = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rangeEnd"u8))
                {
                    rangeEnd = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalysisIPv4FirewallRule(firewallRuleName, rangeStart, rangeEnd, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalysisIPv4FirewallRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalysisIPv4FirewallRule)} does not support writing '{options.Format}' format.");
            }
        }

        AnalysisIPv4FirewallRule IPersistableModel<AnalysisIPv4FirewallRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalysisIPv4FirewallRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalysisIPv4FirewallRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalysisIPv4FirewallRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
