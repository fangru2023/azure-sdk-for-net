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
    [JsonConverter(typeof(MongoDbLinkedServiceConverter))]
    public partial class MongoDbLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, ParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<object> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("server"u8);
            writer.WriteObjectValue(Server);
            if (AuthenticationType.HasValue)
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            writer.WritePropertyName("databaseName"u8);
            writer.WriteObjectValue(DatabaseName);
            if (Username != null)
            {
                writer.WritePropertyName("username"u8);
                writer.WriteObjectValue(Username);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            if (AuthSource != null)
            {
                writer.WritePropertyName("authSource"u8);
                writer.WriteObjectValue(AuthSource);
            }
            if (Port != null)
            {
                writer.WritePropertyName("port"u8);
                writer.WriteObjectValue(Port);
            }
            if (EnableSsl != null)
            {
                writer.WritePropertyName("enableSsl"u8);
                writer.WriteObjectValue(EnableSsl);
            }
            if (AllowSelfSignedServerCert != null)
            {
                writer.WritePropertyName("allowSelfSignedServerCert"u8);
                writer.WriteObjectValue(AllowSelfSignedServerCert);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static MongoDbLinkedService DeserializeMongoDbLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            object server = default;
            MongoDbAuthenticationType? authenticationType = default;
            object databaseName = default;
            object username = default;
            SecretBase password = default;
            object authSource = default;
            object port = default;
            object enableSsl = default;
            object allowSelfSignedServerCert = default;
            object encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("server"u8))
                        {
                            server = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationType = new MongoDbAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("username"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authSource = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableSsl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableSsl = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("allowSelfSignedServerCert"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowSelfSignedServerCert = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MongoDbLinkedService(
                type,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                annotations ?? new ChangeTrackingList<object>(),
                additionalProperties,
                server,
                authenticationType,
                databaseName,
                username,
                password,
                authSource,
                port,
                enableSsl,
                allowSelfSignedServerCert,
                encryptedCredential);
        }

        internal partial class MongoDbLinkedServiceConverter : JsonConverter<MongoDbLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, MongoDbLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MongoDbLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMongoDbLinkedService(document.RootElement);
            }
        }
    }
}
