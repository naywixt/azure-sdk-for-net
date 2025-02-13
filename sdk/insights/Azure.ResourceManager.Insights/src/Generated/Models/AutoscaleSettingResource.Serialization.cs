// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class AutoscaleSettingResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("profiles");
            writer.WriteStartArray();
            foreach (var item in Profiles)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications");
                writer.WriteStartArray();
                foreach (var item in Notifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(NamePropertiesName);
            }
            if (Optional.IsDefined(TargetResourceUri))
            {
                writer.WritePropertyName("targetResourceUri");
                writer.WriteStringValue(TargetResourceUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AutoscaleSettingResource DeserializeAutoscaleSettingResource(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            IList<AutoscaleProfile> profiles = default;
            Optional<IList<AutoscaleNotification>> notifications = default;
            Optional<bool> enabled = default;
            Optional<string> name0 = default;
            Optional<string> targetResourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("profiles"))
                        {
                            List<AutoscaleProfile> array = new List<AutoscaleProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleProfile.DeserializeAutoscaleProfile(item));
                            }
                            profiles = array;
                            continue;
                        }
                        if (property0.NameEquals("notifications"))
                        {
                            List<AutoscaleNotification> array = new List<AutoscaleNotification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleNotification.DeserializeAutoscaleNotification(item));
                            }
                            notifications = array;
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("name"))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceUri"))
                        {
                            targetResourceUri = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutoscaleSettingResource(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), profiles, Optional.ToList(notifications), Optional.ToNullable(enabled), name0.Value, targetResourceUri.Value);
        }
    }
}
