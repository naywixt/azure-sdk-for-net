// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class ODataLinkedService : IUtf8JsonSerializable
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
            writer.WritePropertyName("url");
            writer.WriteObjectValue(Url);
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType");
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName");
                writer.WriteObjectValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant");
                writer.WriteObjectValue(Tenant);
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId");
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (Optional.IsDefined(AadResourceId))
            {
                writer.WritePropertyName("aadResourceId");
                writer.WriteObjectValue(AadResourceId);
            }
            if (Optional.IsDefined(AadServicePrincipalCredentialType))
            {
                writer.WritePropertyName("aadServicePrincipalCredentialType");
                writer.WriteStringValue(AadServicePrincipalCredentialType.Value.ToString());
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey");
                writer.WriteObjectValue(ServicePrincipalKey);
            }
            if (Optional.IsDefined(ServicePrincipalEmbeddedCert))
            {
                writer.WritePropertyName("servicePrincipalEmbeddedCert");
                writer.WriteObjectValue(ServicePrincipalEmbeddedCert);
            }
            if (Optional.IsDefined(ServicePrincipalEmbeddedCertPassword))
            {
                writer.WritePropertyName("servicePrincipalEmbeddedCertPassword");
                writer.WriteObjectValue(ServicePrincipalEmbeddedCertPassword);
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

        internal static ODataLinkedService DeserializeODataLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object url = default;
            Optional<ODataAuthenticationType> authenticationType = default;
            Optional<object> userName = default;
            Optional<SecretBase> password = default;
            Optional<object> tenant = default;
            Optional<object> servicePrincipalId = default;
            Optional<object> aadResourceId = default;
            Optional<ODataAadServicePrincipalCredentialType> aadServicePrincipalCredentialType = default;
            Optional<SecretBase> servicePrincipalKey = default;
            Optional<SecretBase> servicePrincipalEmbeddedCert = default;
            Optional<SecretBase> servicePrincipalEmbeddedCertPassword = default;
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
                        if (property0.NameEquals("url"))
                        {
                            url = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new ODataAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userName"))
                        {
                            userName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tenant"))
                        {
                            tenant = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"))
                        {
                            servicePrincipalId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("aadResourceId"))
                        {
                            aadResourceId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("aadServicePrincipalCredentialType"))
                        {
                            aadServicePrincipalCredentialType = new ODataAadServicePrincipalCredentialType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"))
                        {
                            servicePrincipalKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalEmbeddedCert"))
                        {
                            servicePrincipalEmbeddedCert = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalEmbeddedCertPassword"))
                        {
                            servicePrincipalEmbeddedCertPassword = SecretBase.DeserializeSecretBase(property0.Value);
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
            return new ODataLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, url, Optional.ToNullable(authenticationType), userName.Value, password.Value, tenant.Value, servicePrincipalId.Value, aadResourceId.Value, Optional.ToNullable(aadServicePrincipalCredentialType), servicePrincipalKey.Value, servicePrincipalEmbeddedCert.Value, servicePrincipalEmbeddedCertPassword.Value, encryptedCredential.Value);
        }
    }
}
