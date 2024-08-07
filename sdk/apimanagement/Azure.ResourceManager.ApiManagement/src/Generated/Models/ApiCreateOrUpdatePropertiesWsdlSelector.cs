// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Criteria to limit import of WSDL to a subset of the document. </summary>
    public partial class ApiCreateOrUpdatePropertiesWsdlSelector
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

        /// <summary> Initializes a new instance of <see cref="ApiCreateOrUpdatePropertiesWsdlSelector"/>. </summary>
        public ApiCreateOrUpdatePropertiesWsdlSelector()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiCreateOrUpdatePropertiesWsdlSelector"/>. </summary>
        /// <param name="wsdlServiceName"> Name of service to import from WSDL. </param>
        /// <param name="wsdlEndpointName"> Name of endpoint(port) to import from WSDL. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiCreateOrUpdatePropertiesWsdlSelector(string wsdlServiceName, string wsdlEndpointName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            WsdlServiceName = wsdlServiceName;
            WsdlEndpointName = wsdlEndpointName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of service to import from WSDL. </summary>
        [WirePath("wsdlServiceName")]
        public string WsdlServiceName { get; set; }
        /// <summary> Name of endpoint(port) to import from WSDL. </summary>
        [WirePath("wsdlEndpointName")]
        public string WsdlEndpointName { get; set; }
    }
}
