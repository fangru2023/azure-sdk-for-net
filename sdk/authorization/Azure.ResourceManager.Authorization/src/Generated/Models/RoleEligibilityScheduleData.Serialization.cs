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
    public partial class RoleEligibilityScheduleData : IUtf8JsonSerializable, IJsonModel<RoleEligibilityScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleEligibilityScheduleData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleEligibilityScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleEligibilityScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleEligibilityScheduleData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("principalType"u8);
                writer.WriteStringValue(PrincipalType.Value.ToString());
            }
            if (Optional.IsDefined(RoleEligibilityScheduleRequestId))
            {
                writer.WritePropertyName("roleEligibilityScheduleRequestId"u8);
                writer.WriteStringValue(RoleEligibilityScheduleRequestId);
            }
            if (Optional.IsDefined(MemberType))
            {
                writer.WritePropertyName("memberType"u8);
                writer.WriteStringValue(MemberType.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStringValue(Condition);
            }
            if (Optional.IsDefined(ConditionVersion))
            {
                writer.WritePropertyName("conditionVersion"u8);
                writer.WriteStringValue(ConditionVersion);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedOn"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ExpandedProperties))
            {
                writer.WritePropertyName("expandedProperties"u8);
                writer.WriteObjectValue(ExpandedProperties);
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

        RoleEligibilityScheduleData IJsonModel<RoleEligibilityScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleEligibilityScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleEligibilityScheduleData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleEligibilityScheduleData(document.RootElement, options);
        }

        internal static RoleEligibilityScheduleData DeserializeRoleEligibilityScheduleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> scope = default;
            Optional<ResourceIdentifier> roleDefinitionId = default;
            Optional<Guid> principalId = default;
            Optional<RoleManagementPrincipalType> principalType = default;
            Optional<ResourceIdentifier> roleEligibilityScheduleRequestId = default;
            Optional<RoleManagementScheduleMemberType> memberType = default;
            Optional<RoleManagementScheduleStatus> status = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<string> condition = default;
            Optional<string> conditionVersion = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> updatedOn = default;
            Optional<RoleManagementExpandedProperties> expandedProperties = default;
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
                        if (property0.NameEquals("principalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("principalType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalType = new RoleManagementPrincipalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("roleEligibilityScheduleRequestId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleEligibilityScheduleRequestId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("memberType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memberType = new RoleManagementScheduleMemberType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new RoleManagementScheduleStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("condition"u8))
                        {
                            condition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("conditionVersion"u8))
                        {
                            conditionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expandedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expandedProperties = RoleManagementExpandedProperties.DeserializeRoleManagementExpandedProperties(property0.Value);
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
            return new RoleEligibilityScheduleData(id, name, type, systemData.Value, scope.Value, roleDefinitionId.Value, Optional.ToNullable(principalId), Optional.ToNullable(principalType), roleEligibilityScheduleRequestId.Value, Optional.ToNullable(memberType), Optional.ToNullable(status), Optional.ToNullable(startDateTime), Optional.ToNullable(endDateTime), condition.Value, conditionVersion.Value, Optional.ToNullable(createdOn), Optional.ToNullable(updatedOn), expandedProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleEligibilityScheduleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleEligibilityScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleEligibilityScheduleData)} does not support '{options.Format}' format.");
            }
        }

        RoleEligibilityScheduleData IPersistableModel<RoleEligibilityScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleEligibilityScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleEligibilityScheduleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleEligibilityScheduleData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleEligibilityScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
