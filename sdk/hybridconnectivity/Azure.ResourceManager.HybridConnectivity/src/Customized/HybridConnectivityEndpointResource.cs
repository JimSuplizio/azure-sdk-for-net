﻿﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridConnectivity.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary>
    /// A Class representing a HybridConnectivityEndpoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HybridConnectivityEndpointResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHybridConnectivityEndpointResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetHybridConnectivityEndpoint method.
    /// </summary>
    public partial class HybridConnectivityEndpointResource : ArmResource
    {
        /// <summary>
        /// Gets the ingress gateway endpoint credentials
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointResources_ListIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IngressGatewayAsset>> GetIngressGatewayCredentialsAsync(long? expiresin, CancellationToken cancellationToken)
        {
            using var scope = _hybridConnectivityEndpointEndpointResourcesClientDiagnostics.CreateScope("HybridConnectivityEndpointResource.GetIngressGatewayCredentials");
            scope.Start();
            try
            {
                var response = await _hybridConnectivityEndpointEndpointResourcesRestClient.ListIngressGatewayCredentialsAsync(Id.Parent, Id.Name, null, expiresin, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary>
        /// Gets the ingress gateway endpoint credentials
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointResources_ListIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IngressGatewayAsset> GetIngressGatewayCredentials(long? expiresin, CancellationToken cancellationToken)
        {
            using var scope = _hybridConnectivityEndpointEndpointResourcesClientDiagnostics.CreateScope("HybridConnectivityEndpointResource.GetIngressGatewayCredentials");
            scope.Start();
            try
            {
                var response = _hybridConnectivityEndpointEndpointResourcesRestClient.ListIngressGatewayCredentials(Id.Parent, Id.Name, null, expiresin, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}