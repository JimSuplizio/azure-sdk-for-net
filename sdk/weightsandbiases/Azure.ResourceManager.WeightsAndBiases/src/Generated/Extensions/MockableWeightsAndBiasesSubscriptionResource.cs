// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.WeightsAndBiases.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableWeightsAndBiasesSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _weightsAndBiasesInstanceInstancesClientDiagnostics;
        private InstancesRestOperations _weightsAndBiasesInstanceInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableWeightsAndBiasesSubscriptionResource"/> class for mocking. </summary>
        protected MockableWeightsAndBiasesSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableWeightsAndBiasesSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableWeightsAndBiasesSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics WeightsAndBiasesInstanceInstancesClientDiagnostics => _weightsAndBiasesInstanceInstancesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.WeightsAndBiases", WeightsAndBiasesInstanceResource.ResourceType.Namespace, Diagnostics);
        private InstancesRestOperations WeightsAndBiasesInstanceInstancesRestClient => _weightsAndBiasesInstanceInstancesRestClient ??= new InstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(WeightsAndBiasesInstanceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.WeightsAndBiases/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WeightsAndBiasesInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WeightsAndBiasesInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WeightsAndBiasesInstanceResource> GetWeightsAndBiasesInstancesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => WeightsAndBiasesInstanceInstancesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => WeightsAndBiasesInstanceInstancesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WeightsAndBiasesInstanceResource(Client, WeightsAndBiasesInstanceData.DeserializeWeightsAndBiasesInstanceData(e)), WeightsAndBiasesInstanceInstancesClientDiagnostics, Pipeline, "MockableWeightsAndBiasesSubscriptionResource.GetWeightsAndBiasesInstances", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.WeightsAndBiases/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WeightsAndBiasesInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WeightsAndBiasesInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WeightsAndBiasesInstanceResource> GetWeightsAndBiasesInstances(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => WeightsAndBiasesInstanceInstancesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => WeightsAndBiasesInstanceInstancesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WeightsAndBiasesInstanceResource(Client, WeightsAndBiasesInstanceData.DeserializeWeightsAndBiasesInstanceData(e)), WeightsAndBiasesInstanceInstancesClientDiagnostics, Pipeline, "MockableWeightsAndBiasesSubscriptionResource.GetWeightsAndBiasesInstances", "value", "nextLink", cancellationToken);
        }
    }
}
