// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGroupResource" /> and their operations.
    /// Each <see cref="ResourceGroupResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="ResourceGroupCollection" /> instance call the GetResourceGroups method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class ResourceGroupCollection : ArmCollection, IEnumerable<ResourceGroupResource>, IAsyncEnumerable<ResourceGroupResource>
    {
        private readonly ClientDiagnostics _resourceGroupClientDiagnostics;
        private readonly ResourceGroupsRestOperations _resourceGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupCollection"/> class for mocking. </summary>
        protected ResourceGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourceGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGroupResource.ResourceType, out string resourceGroupApiVersion);
            _resourceGroupRestClient = new ResourceGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. Can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters. </param>
        /// <param name="data"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceGroupName, ResourceGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, resourceGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<ResourceGroupResource>(Response.FromValue(new ResourceGroupResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. Can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters. </param>
        /// <param name="data"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourceGroupResource> CreateOrUpdate(WaitUntil waitUntil, string resourceGroupName, ResourceGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.CreateOrUpdate(Id.SubscriptionId, resourceGroupName, data, cancellationToken);
                var operation = new ResourcesArmOperation<ResourceGroupResource>(Response.FromValue(new ResourceGroupResource(Client, response), response.GetRawResponse()));
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
        /// Gets a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual async Task<Response<ResourceGroupResource>> GetAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.GetAsync(Id.SubscriptionId, resourceGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Response<ResourceGroupResource> Get(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.Get(Id.SubscriptionId, resourceGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the resource groups for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups
        /// Operation Id: ResourceGroups_List
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation.&lt;br&gt;&lt;br&gt;You can filter by tag names and values. For example, to filter for a tag name and value, use $filter=tagName eq &apos;tag1&apos; and tagValue eq &apos;Value1&apos;. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroupResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupRestClient.ListAsync(Id.SubscriptionId, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the resource groups for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups
        /// Operation Id: ResourceGroups_List
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation.&lt;br&gt;&lt;br&gt;You can filter by tag names and values. For example, to filter for a tag name and value, use $filter=tagName eq &apos;tag1&apos; and tagValue eq &apos;Value1&apos;. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroupResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupRestClient.List(Id.SubscriptionId, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupRestClient.ListNextPage(nextLink, Id.SubscriptionId, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.GetAsync(Id.SubscriptionId, resourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.Get(Id.SubscriptionId, resourceGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGroupResource> IEnumerable<ResourceGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroupResource> IAsyncEnumerable<ResourceGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
