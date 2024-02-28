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
    public partial class AutoscaleSettingPatch : IUtf8JsonSerializable, IJsonModel<AutoscaleSettingPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleSettingPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoscaleSettingPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(Profiles is ChangeTrackingList<AutoscaleProfile> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("profiles"u8);
                writer.WriteStartArray();
                foreach (var item in Profiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Notifications is ChangeTrackingList<AutoscaleNotification> collection1 && collection1.IsUndefined))
            {
                if (Notifications != null)
                {
                    writer.WritePropertyName("notifications"u8);
                    writer.WriteStartArray();
                    foreach (var item in Notifications)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("notifications");
                }
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (PredictiveAutoscalePolicy != null)
            {
                if (PredictiveAutoscalePolicy != null)
                {
                    writer.WritePropertyName("predictiveAutoscalePolicy"u8);
                    writer.WriteObjectValue(PredictiveAutoscalePolicy);
                }
                else
                {
                    writer.WriteNull("predictiveAutoscalePolicy");
                }
            }
            if (AutoscaleSettingName != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(AutoscaleSettingName);
            }
            if (TargetResourceId != null)
            {
                writer.WritePropertyName("targetResourceUri"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (TargetResourceLocation.HasValue)
            {
                writer.WritePropertyName("targetResourceLocation"u8);
                writer.WriteStringValue(TargetResourceLocation.Value);
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

        AutoscaleSettingPatch IJsonModel<AutoscaleSettingPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleSettingPatch(document.RootElement, options);
        }

        internal static AutoscaleSettingPatch DeserializeAutoscaleSettingPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            IList<AutoscaleProfile> profiles = default;
            IList<AutoscaleNotification> notifications = default;
            bool? enabled = default;
            PredictiveAutoscalePolicy predictiveAutoscalePolicy = default;
            string name = default;
            ResourceIdentifier targetResourceUri = default;
            AzureLocation? targetResourceLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
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
                        if (property0.NameEquals("profiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AutoscaleProfile> array = new List<AutoscaleProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleProfile.DeserializeAutoscaleProfile(item, options));
                            }
                            profiles = array;
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                notifications = null;
                                continue;
                            }
                            List<AutoscaleNotification> array = new List<AutoscaleNotification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleNotification.DeserializeAutoscaleNotification(item, options));
                            }
                            notifications = array;
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("predictiveAutoscalePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                predictiveAutoscalePolicy = null;
                                continue;
                            }
                            predictiveAutoscalePolicy = PredictiveAutoscalePolicy.DeserializePredictiveAutoscalePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("name"u8))
                        {
                            name = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceUri = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetResourceLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceLocation = new AzureLocation(property0.Value.GetString());
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
            return new AutoscaleSettingPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                profiles ?? new ChangeTrackingList<AutoscaleProfile>(),
                notifications ?? new ChangeTrackingList<AutoscaleNotification>(),
                enabled,
                predictiveAutoscalePolicy,
                name,
                targetResourceUri,
                targetResourceLocation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleSettingPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingPatch)} does not support '{options.Format}' format.");
            }
        }

        AutoscaleSettingPatch IPersistableModel<AutoscaleSettingPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoscaleSettingPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleSettingPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
