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
    [JsonConverter(typeof(DataFlowDebugPackageConverter))]
    public partial class DataFlowDebugPackage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SessionId != null)
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (DataFlow != null)
            {
                writer.WritePropertyName("dataFlow"u8);
                writer.WriteObjectValue(DataFlow);
            }
            if (!(DataFlows is ChangeTrackingList<DataFlowDebugResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataFlows"u8);
                writer.WriteStartArray();
                foreach (var item in DataFlows)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Datasets is ChangeTrackingList<DatasetDebugResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LinkedServices is ChangeTrackingList<LinkedServiceDebugResource> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("linkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Staging != null)
            {
                writer.WritePropertyName("staging"u8);
                writer.WriteObjectValue(Staging);
            }
            if (DebugSettings != null)
            {
                writer.WritePropertyName("debugSettings"u8);
                writer.WriteObjectValue(DebugSettings);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowDebugPackage DeserializeDataFlowDebugPackage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sessionId = default;
            DataFlowDebugResource dataFlow = default;
            IList<DataFlowDebugResource> dataFlows = default;
            IList<DatasetDebugResource> datasets = default;
            IList<LinkedServiceDebugResource> linkedServices = default;
            DataFlowStagingInfo staging = default;
            DataFlowDebugPackageDebugSettings debugSettings = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlow = DataFlowDebugResource.DeserializeDataFlowDebugResource(property.Value);
                    continue;
                }
                if (property.NameEquals("dataFlows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowDebugResource> array = new List<DataFlowDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowDebugResource.DeserializeDataFlowDebugResource(item));
                    }
                    dataFlows = array;
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetDebugResource> array = new List<DatasetDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetDebugResource.DeserializeDatasetDebugResource(item));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("linkedServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedServiceDebugResource> array = new List<LinkedServiceDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceDebugResource.DeserializeLinkedServiceDebugResource(item));
                    }
                    linkedServices = array;
                    continue;
                }
                if (property.NameEquals("staging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    staging = DataFlowStagingInfo.DeserializeDataFlowStagingInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("debugSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSettings = DataFlowDebugPackageDebugSettings.DeserializeDataFlowDebugPackageDebugSettings(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowDebugPackage(
                sessionId,
                dataFlow,
                dataFlows ?? new ChangeTrackingList<DataFlowDebugResource>(),
                datasets ?? new ChangeTrackingList<DatasetDebugResource>(),
                linkedServices ?? new ChangeTrackingList<LinkedServiceDebugResource>(),
                staging,
                debugSettings,
                additionalProperties);
        }

        internal partial class DataFlowDebugPackageConverter : JsonConverter<DataFlowDebugPackage>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugPackage model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugPackage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugPackage(document.RootElement);
            }
        }
    }
}
