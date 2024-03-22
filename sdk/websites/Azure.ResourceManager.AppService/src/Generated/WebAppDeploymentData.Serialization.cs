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

namespace Azure.ResourceManager.AppService
{
    public partial class WebAppDeploymentData : IUtf8JsonSerializable, IJsonModel<WebAppDeploymentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppDeploymentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppDeploymentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppDeploymentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppDeploymentData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteNumberValue(Status.Value);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (Optional.IsDefined(Deployer))
            {
                writer.WritePropertyName("deployer"u8);
                writer.WriteStringValue(Deployer);
            }
            if (Optional.IsDefined(AuthorEmail))
            {
                writer.WritePropertyName("author_email"u8);
                writer.WriteStringValue(AuthorEmail);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("start_time"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("end_time"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(IsActive))
            {
                writer.WritePropertyName("active"u8);
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStringValue(Details);
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

        WebAppDeploymentData IJsonModel<WebAppDeploymentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppDeploymentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppDeploymentData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppDeploymentData(document.RootElement, options);
        }

        internal static WebAppDeploymentData DeserializeWebAppDeploymentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? status = default;
            string message = default;
            string author = default;
            string deployer = default;
            string authorEmail = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            bool? active = default;
            string details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author"u8))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deployer"u8))
                        {
                            deployer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author_email"u8))
                        {
                            authorEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("start_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("end_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("active"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            active = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            details = property0.Value.GetString();
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
            return new WebAppDeploymentData(
                id,
                name,
                type,
                systemData,
                status,
                message,
                author,
                deployer,
                authorEmail,
                startTime,
                endTime,
                active,
                details,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebAppDeploymentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppDeploymentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebAppDeploymentData)} does not support writing '{options.Format}' format.");
            }
        }

        WebAppDeploymentData IPersistableModel<WebAppDeploymentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppDeploymentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppDeploymentData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppDeploymentData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppDeploymentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
