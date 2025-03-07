// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    internal partial class AddonsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AddonsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AddonsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByRoleRequestUri(string subscriptionId, string resourceGroupName, string deviceName, string roleName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByRoleRequest(string subscriptionId, string resourceGroupName, string deviceName, string roleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the addons configured in the role. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AddonList>> ListByRoleAsync(string subscriptionId, string resourceGroupName, string deviceName, string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var message = CreateListByRoleRequest(subscriptionId, resourceGroupName, deviceName, roleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddonList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AddonList.DeserializeAddonList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the addons configured in the role. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AddonList> ListByRole(string subscriptionId, string resourceGroupName, string deviceName, string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var message = CreateListByRoleRequest(subscriptionId, resourceGroupName, deviceName, roleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddonList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AddonList.DeserializeAddonList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons/", false);
            uri.AppendPath(addonName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons/", false);
            uri.AppendPath(addonName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a specific addon by name. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataBoxEdgeRoleAddonData>> GetAsync(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, deviceName, roleName, addonName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataBoxEdgeRoleAddonData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = DataBoxEdgeRoleAddonData.DeserializeDataBoxEdgeRoleAddonData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataBoxEdgeRoleAddonData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a specific addon by name. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataBoxEdgeRoleAddonData> Get(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, deviceName, roleName, addonName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataBoxEdgeRoleAddonData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = DataBoxEdgeRoleAddonData.DeserializeDataBoxEdgeRoleAddonData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataBoxEdgeRoleAddonData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, DataBoxEdgeRoleAddonData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons/", false);
            uri.AppendPath(addonName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, DataBoxEdgeRoleAddonData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons/", false);
            uri.AppendPath(addonName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a addon. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="data"> The addon properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/>, <paramref name="addonName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, DataBoxEdgeRoleAddonData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, deviceName, roleName, addonName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a addon. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="data"> The addon properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/>, <paramref name="addonName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, DataBoxEdgeRoleAddonData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, deviceName, roleName, addonName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons/", false);
            uri.AppendPath(addonName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/roles/", false);
            uri.AppendPath(roleName, true);
            uri.AppendPath("/addons/", false);
            uri.AppendPath(addonName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the addon on the device. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, deviceName, roleName, addonName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the addon on the device. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/>, <paramref name="roleName"/> or <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string deviceName, string roleName, string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, deviceName, roleName, addonName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByRoleNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string deviceName, string roleName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByRoleNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string deviceName, string roleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the addons configured in the role. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AddonList>> ListByRoleNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string deviceName, string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var message = CreateListByRoleNextPageRequest(nextLink, subscriptionId, resourceGroupName, deviceName, roleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddonList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AddonList.DeserializeAddonList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the addons configured in the role. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AddonList> ListByRoleNextPage(string nextLink, string subscriptionId, string resourceGroupName, string deviceName, string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var message = CreateListByRoleNextPageRequest(nextLink, subscriptionId, resourceGroupName, deviceName, roleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddonList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AddonList.DeserializeAddonList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
