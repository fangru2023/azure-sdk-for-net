// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBIndexingPolicy : IUtf8JsonSerializable, IJsonModel<CosmosDBIndexingPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBIndexingPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBIndexingPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsAutomatic))
            {
                writer.WritePropertyName("automatic"u8);
                writer.WriteBooleanValue(IsAutomatic.Value);
            }
            if (Optional.IsDefined(IndexingMode))
            {
                writer.WritePropertyName("indexingMode"u8);
                writer.WriteStringValue(IndexingMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IncludedPaths))
            {
                writer.WritePropertyName("includedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedPaths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CompositeIndexes))
            {
                writer.WritePropertyName("compositeIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in CompositeIndexes)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SpatialIndexes))
            {
                writer.WritePropertyName("spatialIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in SpatialIndexes)
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

        CosmosDBIndexingPolicy IJsonModel<CosmosDBIndexingPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBIndexingPolicy(document.RootElement, options);
        }

        internal static CosmosDBIndexingPolicy DeserializeCosmosDBIndexingPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? automatic = default;
            CosmosDBIndexingMode? indexingMode = default;
            IList<CosmosDBIncludedPath> includedPaths = default;
            IList<CosmosDBExcludedPath> excludedPaths = default;
            IList<IList<CosmosDBCompositePath>> compositeIndexes = default;
            IList<SpatialSpec> spatialIndexes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automatic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automatic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("indexingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexingMode = new CosmosDBIndexingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("includedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBIncludedPath> array = new List<CosmosDBIncludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBIncludedPath.DeserializeCosmosDBIncludedPath(item, options));
                    }
                    includedPaths = array;
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBExcludedPath> array = new List<CosmosDBExcludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBExcludedPath.DeserializeCosmosDBExcludedPath(item, options));
                    }
                    excludedPaths = array;
                    continue;
                }
                if (property.NameEquals("compositeIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<CosmosDBCompositePath>> array = new List<IList<CosmosDBCompositePath>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<CosmosDBCompositePath> array0 = new List<CosmosDBCompositePath>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(CosmosDBCompositePath.DeserializeCosmosDBCompositePath(item0, options));
                            }
                            array.Add(array0);
                        }
                    }
                    compositeIndexes = array;
                    continue;
                }
                if (property.NameEquals("spatialIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialSpec> array = new List<SpatialSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialSpec.DeserializeSpatialSpec(item, options));
                    }
                    spatialIndexes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBIndexingPolicy(
                automatic,
                indexingMode,
                includedPaths ?? new ChangeTrackingList<CosmosDBIncludedPath>(),
                excludedPaths ?? new ChangeTrackingList<CosmosDBExcludedPath>(),
                compositeIndexes ?? new ChangeTrackingList<IList<CosmosDBCompositePath>>(),
                spatialIndexes ?? new ChangeTrackingList<SpatialSpec>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBIndexingPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBIndexingPolicy IPersistableModel<CosmosDBIndexingPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBIndexingPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBIndexingPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
