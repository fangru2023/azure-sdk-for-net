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
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    public partial class SelfHelpDiagnosticData : IUtf8JsonSerializable, IJsonModel<SelfHelpDiagnosticData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpDiagnosticData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpDiagnosticData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticData)} does not support writing '{format}' format.");
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
            if (Optional.IsCollectionDefined(GlobalParameters))
            {
                writer.WritePropertyName("globalParameters"u8);
                writer.WriteStartObject();
                foreach (var item in GlobalParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Insights))
            {
                writer.WritePropertyName("insights"u8);
                writer.WriteStartArray();
                foreach (var item in Insights)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(AcceptedOn))
            {
                writer.WritePropertyName("acceptedAt"u8);
                writer.WriteStringValue(AcceptedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteStartArray();
                foreach (var item in Diagnostics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SelfHelpDiagnosticData IJsonModel<SelfHelpDiagnosticData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpDiagnosticData(document.RootElement, options);
        }

        internal static SelfHelpDiagnosticData DeserializeSelfHelpDiagnosticData(JsonElement element, ModelReaderWriterOptions options = null)
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
            IDictionary<string, string> globalParameters = default;
            IList<SelfHelpDiagnosticInvocation> insights = default;
            DateTimeOffset? acceptedAt = default;
            SelfHelpProvisioningState? provisioningState = default;
            IReadOnlyList<SelfHelpDiagnosticInfo> diagnostics = default;
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
                        if (property0.NameEquals("globalParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            globalParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("insights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SelfHelpDiagnosticInvocation> array = new List<SelfHelpDiagnosticInvocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SelfHelpDiagnosticInvocation.DeserializeSelfHelpDiagnosticInvocation(item, options));
                            }
                            insights = array;
                            continue;
                        }
                        if (property0.NameEquals("acceptedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            acceptedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SelfHelpProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diagnostics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SelfHelpDiagnosticInfo> array = new List<SelfHelpDiagnosticInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SelfHelpDiagnosticInfo.DeserializeSelfHelpDiagnosticInfo(item, options));
                            }
                            diagnostics = array;
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
            return new SelfHelpDiagnosticData(
                id,
                name,
                type,
                systemData,
                globalParameters ?? new ChangeTrackingDictionary<string, string>(),
                insights ?? new ChangeTrackingList<SelfHelpDiagnosticInvocation>(),
                acceptedAt,
                provisioningState,
                diagnostics ?? new ChangeTrackingList<SelfHelpDiagnosticInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpDiagnosticData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticData)} does not support writing '{options.Format}' format.");
            }
        }

        SelfHelpDiagnosticData IPersistableModel<SelfHelpDiagnosticData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHelpDiagnosticData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHelpDiagnosticData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
