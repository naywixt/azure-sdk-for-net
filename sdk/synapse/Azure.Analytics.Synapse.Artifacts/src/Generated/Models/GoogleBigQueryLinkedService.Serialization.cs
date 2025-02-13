// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class GoogleBigQueryLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("project");
            writer.WriteObjectValue(Project);
            if (Optional.IsDefined(AdditionalProjects))
            {
                writer.WritePropertyName("additionalProjects");
                writer.WriteObjectValue(AdditionalProjects);
            }
            if (Optional.IsDefined(RequestGoogleDriveScope))
            {
                writer.WritePropertyName("requestGoogleDriveScope");
                writer.WriteObjectValue(RequestGoogleDriveScope);
            }
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken");
                writer.WriteObjectValue(RefreshToken);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteObjectValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret");
                writer.WriteObjectValue(ClientSecret);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email");
                writer.WriteObjectValue(Email);
            }
            if (Optional.IsDefined(KeyFilePath))
            {
                writer.WritePropertyName("keyFilePath");
                writer.WriteObjectValue(KeyFilePath);
            }
            if (Optional.IsDefined(TrustedCertPath))
            {
                writer.WritePropertyName("trustedCertPath");
                writer.WriteObjectValue(TrustedCertPath);
            }
            if (Optional.IsDefined(UseSystemTrustStore))
            {
                writer.WritePropertyName("useSystemTrustStore");
                writer.WriteObjectValue(UseSystemTrustStore);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
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

        internal static GoogleBigQueryLinkedService DeserializeGoogleBigQueryLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object project = default;
            Optional<object> additionalProjects = default;
            Optional<object> requestGoogleDriveScope = default;
            GoogleBigQueryAuthenticationType authenticationType = default;
            Optional<SecretBase> refreshToken = default;
            Optional<object> clientId = default;
            Optional<SecretBase> clientSecret = default;
            Optional<object> email = default;
            Optional<object> keyFilePath = default;
            Optional<object> trustedCertPath = default;
            Optional<object> useSystemTrustStore = default;
            Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("project"))
                        {
                            project = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("additionalProjects"))
                        {
                            additionalProjects = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("requestGoogleDriveScope"))
                        {
                            requestGoogleDriveScope = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new GoogleBigQueryAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("refreshToken"))
                        {
                            refreshToken = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientId"))
                        {
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"))
                        {
                            clientSecret = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("email"))
                        {
                            email = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("keyFilePath"))
                        {
                            keyFilePath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"))
                        {
                            trustedCertPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"))
                        {
                            useSystemTrustStore = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GoogleBigQueryLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, project, additionalProjects.Value, requestGoogleDriveScope.Value, authenticationType, refreshToken.Value, clientId.Value, clientSecret.Value, email.Value, keyFilePath.Value, trustedCertPath.Value, useSystemTrustStore.Value, encryptedCredential.Value);
        }
    }
}
