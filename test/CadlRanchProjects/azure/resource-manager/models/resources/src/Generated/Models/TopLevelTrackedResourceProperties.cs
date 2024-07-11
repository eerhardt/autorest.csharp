// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Azure.ResourceManager.Models.Resources.Models
{
    /// <summary> Top Level Arm Resource Properties. </summary>
    public partial class TopLevelTrackedResourceProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TopLevelTrackedResourceProperties"/>. </summary>
        public TopLevelTrackedResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TopLevelTrackedResourceProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="description"> The description of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TopLevelTrackedResourceProperties(ProvisioningState? provisioningState, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The description of the resource. </summary>
        public string Description { get; set; }
    }
}