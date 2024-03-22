// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleManagementPolicyAssignmentData : IUtf8JsonSerializable, IJsonModel<RoleManagementPolicyAssignmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleManagementPolicyAssignmentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleManagementPolicyAssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyAssignmentData)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("roleDefinitionId"u8);
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(EffectiveRules))
            {
                writer.WritePropertyName("effectiveRules"u8);
                writer.WriteStartArray();
                foreach (var item in EffectiveRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyAssignmentProperties))
            {
                writer.WritePropertyName("policyAssignmentProperties"u8);
                writer.WriteObjectValue(PolicyAssignmentProperties);
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

        RoleManagementPolicyAssignmentData IJsonModel<RoleManagementPolicyAssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyAssignmentData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementPolicyAssignmentData(document.RootElement, options);
        }

        internal static RoleManagementPolicyAssignmentData DeserializeRoleManagementPolicyAssignmentData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string scope = default;
            ResourceIdentifier roleDefinitionId = default;
            ResourceIdentifier policyId = default;
            IReadOnlyList<RoleManagementPolicyRule> effectiveRules = default;
            PolicyAssignmentProperties policyAssignmentProperties = default;
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
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("policyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("effectiveRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RoleManagementPolicyRule> array = new List<RoleManagementPolicyRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoleManagementPolicyRule.DeserializeRoleManagementPolicyRule(item, options));
                            }
                            effectiveRules = array;
                            continue;
                        }
                        if (property0.NameEquals("policyAssignmentProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyAssignmentProperties = PolicyAssignmentProperties.DeserializePolicyAssignmentProperties(property0.Value, options);
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
            return new RoleManagementPolicyAssignmentData(
                id,
                name,
                type,
                systemData,
                scope,
                roleDefinitionId,
                policyId,
                effectiveRules ?? new ChangeTrackingList<RoleManagementPolicyRule>(),
                policyAssignmentProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleManagementPolicyAssignmentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyAssignmentData)} does not support writing '{options.Format}' format.");
            }
        }

        RoleManagementPolicyAssignmentData IPersistableModel<RoleManagementPolicyAssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleManagementPolicyAssignmentData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyAssignmentData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleManagementPolicyAssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
