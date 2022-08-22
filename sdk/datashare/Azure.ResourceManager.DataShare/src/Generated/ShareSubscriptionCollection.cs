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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="ShareSubscriptionResource" /> and their operations.
    /// Each <see cref="ShareSubscriptionResource" /> in the collection will belong to the same instance of <see cref="AccountResource" />.
    /// To get a <see cref="ShareSubscriptionCollection" /> instance call the GetShareSubscriptions method from an instance of <see cref="AccountResource" />.
    /// </summary>
    public partial class ShareSubscriptionCollection : ArmCollection, IEnumerable<ShareSubscriptionResource>, IAsyncEnumerable<ShareSubscriptionResource>
    {
        private readonly ClientDiagnostics _shareSubscriptionClientDiagnostics;
        private readonly ShareSubscriptionsRestOperations _shareSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ShareSubscriptionCollection"/> class for mocking. </summary>
        protected ShareSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ShareSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ShareSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _shareSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", ShareSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ShareSubscriptionResource.ResourceType, out string shareSubscriptionApiVersion);
            _shareSubscriptionRestClient = new ShareSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, shareSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a shareSubscription in an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}
        /// Operation Id: ShareSubscriptions_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="data"> create parameters for shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ShareSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string shareSubscriptionName, ShareSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _shareSubscriptionRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareSubscriptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<ShareSubscriptionResource>(Response.FromValue(new ShareSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Create a shareSubscription in an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}
        /// Operation Id: ShareSubscriptions_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="data"> create parameters for shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ShareSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string shareSubscriptionName, ShareSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _shareSubscriptionRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareSubscriptionName, data, cancellationToken);
                var operation = new DataShareArmOperation<ShareSubscriptionResource>(Response.FromValue(new ShareSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Get a shareSubscription in an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}
        /// Operation Id: ShareSubscriptions_Get
        /// </summary>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<ShareSubscriptionResource>> GetAsync(string shareSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _shareSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareSubscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shareSubscription in an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}
        /// Operation Id: ShareSubscriptions_Get
        /// </summary>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSubscriptionName"/> is null. </exception>
        public virtual Response<ShareSubscriptionResource> Get(string shareSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _shareSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareSubscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List share subscriptions in an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions
        /// Operation Id: ShareSubscriptions_ListByAccount
        /// </summary>
        /// <param name="skipToken"> Continuation Token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ShareSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ShareSubscriptionResource> GetAllAsync(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ShareSubscriptionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _shareSubscriptionRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ShareSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ShareSubscriptionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _shareSubscriptionRestClient.ListByAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ShareSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List share subscriptions in an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions
        /// Operation Id: ShareSubscriptions_ListByAccount
        /// </summary>
        /// <param name="skipToken"> Continuation Token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ShareSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ShareSubscriptionResource> GetAll(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Page<ShareSubscriptionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _shareSubscriptionRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ShareSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ShareSubscriptionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _shareSubscriptionRestClient.ListByAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ShareSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}
        /// Operation Id: ShareSubscriptions_Get
        /// </summary>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string shareSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _shareSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}
        /// Operation Id: ShareSubscriptions_Get
        /// </summary>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSubscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string shareSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var scope = _shareSubscriptionClientDiagnostics.CreateScope("ShareSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _shareSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareSubscriptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ShareSubscriptionResource> IEnumerable<ShareSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ShareSubscriptionResource> IAsyncEnumerable<ShareSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
