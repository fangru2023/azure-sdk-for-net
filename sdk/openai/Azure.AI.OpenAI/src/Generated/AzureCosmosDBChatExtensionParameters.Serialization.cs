// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    internal partial class AzureCosmosDBChatExtensionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            if (Optional.IsDefined(DocumentCount))
            {
                writer.WritePropertyName("topNDocuments"u8);
                writer.WriteNumberValue(DocumentCount.Value);
            }
            if (Optional.IsDefined(ShouldRestrictResultScope))
            {
                writer.WritePropertyName("inScope"u8);
                writer.WriteBooleanValue(ShouldRestrictResultScope.Value);
            }
            if (Optional.IsDefined(Strictness))
            {
                writer.WritePropertyName("strictness"u8);
                writer.WriteNumberValue(Strictness.Value);
            }
            if (Optional.IsDefined(RoleInformation))
            {
                writer.WritePropertyName("roleInformation"u8);
                writer.WriteStringValue(RoleInformation);
            }
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("indexName"u8);
            writer.WriteStringValue(IndexName);
            writer.WritePropertyName("fieldsMapping"u8);
            writer.WriteObjectValue(FieldMappingOptions);
            if (Optional.IsDefined(EmbeddingDependency))
            {
                writer.WritePropertyName("embeddingDependency"u8);
                writer.WriteObjectValue(EmbeddingDependency);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
