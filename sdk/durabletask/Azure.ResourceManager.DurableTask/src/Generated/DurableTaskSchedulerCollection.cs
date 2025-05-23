// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DurableTask
{
    /// <summary>
    /// A class representing a collection of <see cref="DurableTaskSchedulerResource"/> and their operations.
    /// Each <see cref="DurableTaskSchedulerResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DurableTaskSchedulerCollection"/> instance call the GetDurableTaskSchedulers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DurableTaskSchedulerCollection : ArmCollection, IEnumerable<DurableTaskSchedulerResource>, IAsyncEnumerable<DurableTaskSchedulerResource>
    {
        private readonly ClientDiagnostics _durableTaskSchedulerSchedulersClientDiagnostics;
        private readonly SchedulersRestOperations _durableTaskSchedulerSchedulersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DurableTaskSchedulerCollection"/> class for mocking. </summary>
        protected DurableTaskSchedulerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DurableTaskSchedulerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DurableTaskSchedulerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _durableTaskSchedulerSchedulersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DurableTask", DurableTaskSchedulerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DurableTaskSchedulerResource.ResourceType, out string durableTaskSchedulerSchedulersApiVersion);
            _durableTaskSchedulerSchedulersRestClient = new SchedulersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, durableTaskSchedulerSchedulersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Scheduler
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DurableTaskSchedulerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string schedulerName, DurableTaskSchedulerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _durableTaskSchedulerSchedulersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DurableTaskArmOperation<DurableTaskSchedulerResource>(new DurableTaskSchedulerOperationSource(Client), _durableTaskSchedulerSchedulersClientDiagnostics, Pipeline, _durableTaskSchedulerSchedulersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a Scheduler
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DurableTaskSchedulerResource> CreateOrUpdate(WaitUntil waitUntil, string schedulerName, DurableTaskSchedulerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _durableTaskSchedulerSchedulersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, data, cancellationToken);
                var operation = new DurableTaskArmOperation<DurableTaskSchedulerResource>(new DurableTaskSchedulerOperationSource(Client), _durableTaskSchedulerSchedulersClientDiagnostics, Pipeline, _durableTaskSchedulerSchedulersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Scheduler
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> is null. </exception>
        public virtual async Task<Response<DurableTaskSchedulerResource>> GetAsync(string schedulerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.Get");
            scope.Start();
            try
            {
                var response = await _durableTaskSchedulerSchedulersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DurableTaskSchedulerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Scheduler
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> is null. </exception>
        public virtual Response<DurableTaskSchedulerResource> Get(string schedulerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.Get");
            scope.Start();
            try
            {
                var response = _durableTaskSchedulerSchedulersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DurableTaskSchedulerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Schedulers by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DurableTaskSchedulerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DurableTaskSchedulerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _durableTaskSchedulerSchedulersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _durableTaskSchedulerSchedulersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DurableTaskSchedulerResource(Client, DurableTaskSchedulerData.DeserializeDurableTaskSchedulerData(e)), _durableTaskSchedulerSchedulersClientDiagnostics, Pipeline, "DurableTaskSchedulerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Schedulers by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DurableTaskSchedulerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DurableTaskSchedulerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _durableTaskSchedulerSchedulersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _durableTaskSchedulerSchedulersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DurableTaskSchedulerResource(Client, DurableTaskSchedulerData.DeserializeDurableTaskSchedulerData(e)), _durableTaskSchedulerSchedulersClientDiagnostics, Pipeline, "DurableTaskSchedulerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schedulerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _durableTaskSchedulerSchedulersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> is null. </exception>
        public virtual Response<bool> Exists(string schedulerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.Exists");
            scope.Start();
            try
            {
                var response = _durableTaskSchedulerSchedulersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> is null. </exception>
        public virtual async Task<NullableResponse<DurableTaskSchedulerResource>> GetIfExistsAsync(string schedulerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _durableTaskSchedulerSchedulersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DurableTaskSchedulerResource>(response.GetRawResponse());
                return Response.FromValue(new DurableTaskSchedulerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DurableTask/schedulers/{schedulerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scheduler_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DurableTaskSchedulerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schedulerName"> The name of the Scheduler. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schedulerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schedulerName"/> is null. </exception>
        public virtual NullableResponse<DurableTaskSchedulerResource> GetIfExists(string schedulerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schedulerName, nameof(schedulerName));

            using var scope = _durableTaskSchedulerSchedulersClientDiagnostics.CreateScope("DurableTaskSchedulerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _durableTaskSchedulerSchedulersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, schedulerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DurableTaskSchedulerResource>(response.GetRawResponse());
                return Response.FromValue(new DurableTaskSchedulerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DurableTaskSchedulerResource> IEnumerable<DurableTaskSchedulerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DurableTaskSchedulerResource> IAsyncEnumerable<DurableTaskSchedulerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
