// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClusterStatus : IUtf8JsonSerializable, IJsonModel<ProvisionedClusterStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClusterStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProvisionedClusterStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ControlPlaneStatus))
            {
                writer.WritePropertyName("controlPlaneStatus"u8);
                writer.WriteStartArray();
                foreach (var item in ControlPlaneStatus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentState))
            {
                writer.WritePropertyName("currentState"u8);
                writer.WriteStringValue(CurrentState.Value.ToString());
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
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

        ProvisionedClusterStatus IJsonModel<ProvisionedClusterStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClusterStatus(document.RootElement, options);
        }

        internal static ProvisionedClusterStatus DeserializeProvisionedClusterStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ProvisionedClusterAddonStatusProfile> controlPlaneStatus = default;
            HybridContainerServiceResourceProvisioningState? currentState = default;
            string errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlPlaneStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProvisionedClusterAddonStatusProfile> array = new List<ProvisionedClusterAddonStatusProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProvisionedClusterAddonStatusProfile.DeserializeProvisionedClusterAddonStatusProfile(item, options));
                    }
                    controlPlaneStatus = array;
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = new HybridContainerServiceResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProvisionedClusterStatus(controlPlaneStatus ?? new ChangeTrackingList<ProvisionedClusterAddonStatusProfile>(), currentState, errorMessage, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProvisionedClusterStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterStatus)} does not support writing '{options.Format}' format.");
            }
        }

        ProvisionedClusterStatus IPersistableModel<ProvisionedClusterStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProvisionedClusterStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProvisionedClusterStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
