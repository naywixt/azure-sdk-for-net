// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineScaleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan");
                writer.WriteObjectValue(Plan);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy");
                writer.WriteObjectValue(UpgradePolicy);
            }
            if (Optional.IsDefined(AutomaticRepairsPolicy))
            {
                writer.WritePropertyName("automaticRepairsPolicy");
                writer.WriteObjectValue(AutomaticRepairsPolicy);
            }
            if (Optional.IsDefined(VirtualMachineProfile))
            {
                writer.WritePropertyName("virtualMachineProfile");
                writer.WriteObjectValue(VirtualMachineProfile);
            }
            if (Optional.IsDefined(Overprovision))
            {
                writer.WritePropertyName("overprovision");
                writer.WriteBooleanValue(Overprovision.Value);
            }
            if (Optional.IsDefined(DoNotRunExtensionsOnOverprovisionedVMs))
            {
                writer.WritePropertyName("doNotRunExtensionsOnOverprovisionedVMs");
                writer.WriteBooleanValue(DoNotRunExtensionsOnOverprovisionedVMs.Value);
            }
            if (Optional.IsDefined(SinglePlacementGroup))
            {
                writer.WritePropertyName("singlePlacementGroup");
                writer.WriteBooleanValue(SinglePlacementGroup.Value);
            }
            if (Optional.IsDefined(ZoneBalance))
            {
                writer.WritePropertyName("zoneBalance");
                writer.WriteBooleanValue(ZoneBalance.Value);
            }
            if (Optional.IsDefined(PlatformFaultDomainCount))
            {
                writer.WritePropertyName("platformFaultDomainCount");
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
            }
            if (Optional.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup");
                writer.WriteObjectValue(ProximityPlacementGroup);
            }
            if (Optional.IsDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities");
                writer.WriteObjectValue(AdditionalCapabilities);
            }
            if (Optional.IsDefined(ScaleInPolicy))
            {
                writer.WritePropertyName("scaleInPolicy");
                writer.WriteObjectValue(ScaleInPolicy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSet DeserializeVirtualMachineScaleSet(JsonElement element)
        {
            Optional<Sku> sku = default;
            Optional<Plan> plan = default;
            Optional<VirtualMachineScaleSetIdentity> identity = default;
            Optional<IList<string>> zones = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<UpgradePolicy> upgradePolicy = default;
            Optional<AutomaticRepairsPolicy> automaticRepairsPolicy = default;
            Optional<VirtualMachineScaleSetVMProfile> virtualMachineProfile = default;
            Optional<string> provisioningState = default;
            Optional<bool> overprovision = default;
            Optional<bool> doNotRunExtensionsOnOverprovisionedVMs = default;
            Optional<string> uniqueId = default;
            Optional<bool> singlePlacementGroup = default;
            Optional<bool> zoneBalance = default;
            Optional<int> platformFaultDomainCount = default;
            Optional<SubResource> proximityPlacementGroup = default;
            Optional<AdditionalCapabilities> additionalCapabilities = default;
            Optional<ScaleInPolicy> scaleInPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("plan"))
                {
                    plan = Plan.DeserializePlan(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = VirtualMachineScaleSetIdentity.DeserializeVirtualMachineScaleSetIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
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
                        if (property0.NameEquals("upgradePolicy"))
                        {
                            upgradePolicy = UpgradePolicy.DeserializeUpgradePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("automaticRepairsPolicy"))
                        {
                            automaticRepairsPolicy = AutomaticRepairsPolicy.DeserializeAutomaticRepairsPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineProfile"))
                        {
                            virtualMachineProfile = VirtualMachineScaleSetVMProfile.DeserializeVirtualMachineScaleSetVMProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overprovision"))
                        {
                            overprovision = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("doNotRunExtensionsOnOverprovisionedVMs"))
                        {
                            doNotRunExtensionsOnOverprovisionedVMs = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("singlePlacementGroup"))
                        {
                            singlePlacementGroup = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("zoneBalance"))
                        {
                            zoneBalance = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("platformFaultDomainCount"))
                        {
                            platformFaultDomainCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"))
                        {
                            proximityPlacementGroup = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalCapabilities"))
                        {
                            additionalCapabilities = AdditionalCapabilities.DeserializeAdditionalCapabilities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("scaleInPolicy"))
                        {
                            scaleInPolicy = ScaleInPolicy.DeserializeScaleInPolicy(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineScaleSet(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), sku.Value, plan.Value, identity.Value, Optional.ToList(zones), upgradePolicy.Value, automaticRepairsPolicy.Value, virtualMachineProfile.Value, provisioningState.Value, Optional.ToNullable(overprovision), Optional.ToNullable(doNotRunExtensionsOnOverprovisionedVMs), uniqueId.Value, Optional.ToNullable(singlePlacementGroup), Optional.ToNullable(zoneBalance), Optional.ToNullable(platformFaultDomainCount), proximityPlacementGroup.Value, additionalCapabilities.Value, scaleInPolicy.Value);
        }
    }
}
