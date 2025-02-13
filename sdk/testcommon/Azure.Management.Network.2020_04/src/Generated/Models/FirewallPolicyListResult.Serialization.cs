// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class FirewallPolicyListResult
    {
        internal static FirewallPolicyListResult DeserializeFirewallPolicyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<FirewallPolicy>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<FirewallPolicy> array = new List<FirewallPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicy.DeserializeFirewallPolicy(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FirewallPolicyListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
