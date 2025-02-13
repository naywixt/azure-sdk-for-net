// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for ApplicationGatewayAvailableSslOptions API service call. </summary>
    public partial class ApplicationGatewayAvailableSslOptions : Resource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayAvailableSslOptions. </summary>
        public ApplicationGatewayAvailableSslOptions()
        {
            PredefinedPolicies = new ChangeTrackingList<SubResource>();
            AvailableCipherSuites = new ChangeTrackingList<ApplicationGatewaySslCipherSuite>();
            AvailableProtocols = new ChangeTrackingList<ApplicationGatewaySslProtocol>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayAvailableSslOptions. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="predefinedPolicies"> List of available Ssl predefined policy. </param>
        /// <param name="defaultPolicy"> Name of the Ssl predefined policy applied by default to application gateway. </param>
        /// <param name="availableCipherSuites"> List of available Ssl cipher suites. </param>
        /// <param name="availableProtocols"> List of available Ssl protocols. </param>
        internal ApplicationGatewayAvailableSslOptions(string id, string name, string type, string location, IDictionary<string, string> tags, IList<SubResource> predefinedPolicies, ApplicationGatewaySslPolicyName? defaultPolicy, IList<ApplicationGatewaySslCipherSuite> availableCipherSuites, IList<ApplicationGatewaySslProtocol> availableProtocols) : base(id, name, type, location, tags)
        {
            PredefinedPolicies = predefinedPolicies;
            DefaultPolicy = defaultPolicy;
            AvailableCipherSuites = availableCipherSuites;
            AvailableProtocols = availableProtocols;
        }

        /// <summary> List of available Ssl predefined policy. </summary>
        public IList<SubResource> PredefinedPolicies { get; }
        /// <summary> Name of the Ssl predefined policy applied by default to application gateway. </summary>
        public ApplicationGatewaySslPolicyName? DefaultPolicy { get; set; }
        /// <summary> List of available Ssl cipher suites. </summary>
        public IList<ApplicationGatewaySslCipherSuite> AvailableCipherSuites { get; }
        /// <summary> List of available Ssl protocols. </summary>
        public IList<ApplicationGatewaySslProtocol> AvailableProtocols { get; }
    }
}
