// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ManagedVirtualNetworkSettingsConverter))]
    public partial class ManagedVirtualNetworkSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PreventDataExfiltration.HasValue)
            {
                writer.WritePropertyName("preventDataExfiltration"u8);
                writer.WriteBooleanValue(PreventDataExfiltration.Value);
            }
            if (LinkedAccessCheckOnTargetResource.HasValue)
            {
                writer.WritePropertyName("linkedAccessCheckOnTargetResource"u8);
                writer.WriteBooleanValue(LinkedAccessCheckOnTargetResource.Value);
            }
            if (!(AllowedAadTenantIdsForLinking is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedAadTenantIdsForLinking"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedAadTenantIdsForLinking)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedVirtualNetworkSettings DeserializeManagedVirtualNetworkSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? preventDataExfiltration = default;
            bool? linkedAccessCheckOnTargetResource = default;
            IList<string> allowedAadTenantIdsForLinking = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preventDataExfiltration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preventDataExfiltration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linkedAccessCheckOnTargetResource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedAccessCheckOnTargetResource = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedAadTenantIdsForLinking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedAadTenantIdsForLinking = array;
                    continue;
                }
            }
            return new ManagedVirtualNetworkSettings(preventDataExfiltration, linkedAccessCheckOnTargetResource, allowedAadTenantIdsForLinking ?? new ChangeTrackingList<string>());
        }

        internal partial class ManagedVirtualNetworkSettingsConverter : JsonConverter<ManagedVirtualNetworkSettings>
        {
            public override void Write(Utf8JsonWriter writer, ManagedVirtualNetworkSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ManagedVirtualNetworkSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeManagedVirtualNetworkSettings(document.RootElement);
            }
        }
    }
}
