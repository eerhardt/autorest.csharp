// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Service Endpoint Policy resource. </summary>
    public partial class ServiceEndpointPolicyPropertiesFormat
    {
        /// <summary> A collection of service endpoint policy definitions of the service endpoint policy. </summary>
        public ICollection<ServiceEndpointPolicyDefinition> ServiceEndpointPolicyDefinitions { get; set; }
        /// <summary> A collection of references to subnets. </summary>
        public ICollection<Subnet> Subnets { get; internal set; }
        /// <summary> The resource GUID property of the service endpoint policy resource. </summary>
        public string ResourceGuid { get; internal set; }
        /// <summary> The provisioning state of the service endpoint policy resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}