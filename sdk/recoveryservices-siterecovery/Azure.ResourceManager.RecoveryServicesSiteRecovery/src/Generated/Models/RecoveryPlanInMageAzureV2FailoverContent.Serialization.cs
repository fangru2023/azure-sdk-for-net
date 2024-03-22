// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanInMageAzureV2FailoverContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageAzureV2FailoverContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointType"u8);
            writer.WriteStringValue(RecoveryPointType.ToString());
            if (Optional.IsDefined(UseMultiVmSyncPoint))
            {
                writer.WritePropertyName("useMultiVmSyncPoint"u8);
                writer.WriteStringValue(UseMultiVmSyncPoint);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        RecoveryPlanInMageAzureV2FailoverContent IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageAzureV2FailoverContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanInMageAzureV2FailoverContent(document.RootElement, options);
        }

        internal static RecoveryPlanInMageAzureV2FailoverContent DeserializeRecoveryPlanInMageAzureV2FailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InMageV2RpRecoveryPointType recoveryPointType = default;
            string useMultiVmSyncPoint = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = new InMageV2RpRecoveryPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useMultiVmSyncPoint"u8))
                {
                    useMultiVmSyncPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPlanInMageAzureV2FailoverContent(instanceType, serializedAdditionalRawData, recoveryPointType, useMultiVmSyncPoint);
        }

        BinaryData IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanInMageAzureV2FailoverContent)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPlanInMageAzureV2FailoverContent IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanInMageAzureV2FailoverContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanInMageAzureV2FailoverContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
