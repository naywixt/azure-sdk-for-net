// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBDatabaseGetPropertiesResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WriteEndObject();
        }

        internal static MongoDBDatabaseGetPropertiesResource DeserializeMongoDBDatabaseGetPropertiesResource(JsonElement element)
        {
            Optional<string> Rid = default;
            Optional<object> Ts = default;
            Optional<string> Etag = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    Rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    Ts = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBDatabaseGetPropertiesResource(id, Rid.Value, Ts.Value, Etag.Value);
        }
    }
}
