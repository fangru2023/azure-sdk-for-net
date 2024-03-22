// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAzureMonitorSelectedConfigurations : IUtf8JsonSerializable, IJsonModel<HDInsightAzureMonitorSelectedConfigurations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAzureMonitorSelectedConfigurations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightAzureMonitorSelectedConfigurations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorSelectedConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAzureMonitorSelectedConfigurations)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConfigurationVersion))
            {
                writer.WritePropertyName("configurationVersion"u8);
                writer.WriteStringValue(ConfigurationVersion);
            }
            if (Optional.IsCollectionDefined(GlobalConfigurations))
            {
                writer.WritePropertyName("globalConfigurations"u8);
                writer.WriteStartObject();
                foreach (var item in GlobalConfigurations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TableList))
            {
                writer.WritePropertyName("tableList"u8);
                writer.WriteStartArray();
                foreach (var item in TableList)
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

        HDInsightAzureMonitorSelectedConfigurations IJsonModel<HDInsightAzureMonitorSelectedConfigurations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorSelectedConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAzureMonitorSelectedConfigurations)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAzureMonitorSelectedConfigurations(document.RootElement, options);
        }

        internal static HDInsightAzureMonitorSelectedConfigurations DeserializeHDInsightAzureMonitorSelectedConfigurations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string configurationVersion = default;
            IDictionary<string, string> globalConfigurations = default;
            IList<HDInsightAzureMonitorTableConfiguration> tableList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationVersion"u8))
                {
                    configurationVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("globalConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    globalConfigurations = dictionary;
                    continue;
                }
                if (property.NameEquals("tableList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightAzureMonitorTableConfiguration> array = new List<HDInsightAzureMonitorTableConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightAzureMonitorTableConfiguration.DeserializeHDInsightAzureMonitorTableConfiguration(item, options));
                    }
                    tableList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightAzureMonitorSelectedConfigurations(configurationVersion, globalConfigurations ?? new ChangeTrackingDictionary<string, string>(), tableList ?? new ChangeTrackingList<HDInsightAzureMonitorTableConfiguration>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAzureMonitorSelectedConfigurations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorSelectedConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAzureMonitorSelectedConfigurations)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightAzureMonitorSelectedConfigurations IPersistableModel<HDInsightAzureMonitorSelectedConfigurations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorSelectedConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightAzureMonitorSelectedConfigurations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAzureMonitorSelectedConfigurations)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAzureMonitorSelectedConfigurations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
