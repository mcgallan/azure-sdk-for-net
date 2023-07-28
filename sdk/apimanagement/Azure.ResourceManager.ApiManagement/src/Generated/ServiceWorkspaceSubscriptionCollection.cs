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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceWorkspaceSubscriptionResource" /> and their operations.
    /// Each <see cref="ServiceWorkspaceSubscriptionResource" /> in the collection will belong to the same instance of <see cref="WorkspaceContractResource" />.
    /// To get a <see cref="ServiceWorkspaceSubscriptionCollection" /> instance call the GetServiceWorkspaceSubscriptions method from an instance of <see cref="WorkspaceContractResource" />.
    /// </summary>
    public partial class ServiceWorkspaceSubscriptionCollection : ArmCollection, IEnumerable<ServiceWorkspaceSubscriptionResource>, IAsyncEnumerable<ServiceWorkspaceSubscriptionResource>
    {
        private readonly ClientDiagnostics _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics;
        private readonly WorkspaceSubscriptionRestOperations _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceSubscriptionCollection"/> class for mocking. </summary>
        protected ServiceWorkspaceSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspaceSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspaceSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspaceSubscriptionResource.ResourceType, out string serviceWorkspaceSubscriptionWorkspaceSubscriptionApiVersion);
            _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient = new WorkspaceSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceSubscriptionWorkspaceSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkspaceContractResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkspaceContractResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the subscription of specified user to the specified product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="subscriptionCreateParameters"> Create parameters. </param>
        /// <param name="notify">
        /// Notify change in Subscription State.
        ///  - If false, do not send any email notification for change of state of subscription
        ///  - If true, send email notification of change of state of subscription
        /// </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="appType"> Determines the type of application which send the create user request. Default is legacy publisher portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> or <paramref name="subscriptionCreateParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sid, SubscriptionCreateParameters subscriptionCreateParameters, bool? notify = null, ETag? ifMatch = null, AppType? appType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));
            Argument.AssertNotNull(subscriptionCreateParameters, nameof(subscriptionCreateParameters));

            using var scope = _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics.CreateScope("ServiceWorkspaceSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, subscriptionCreateParameters, notify, ifMatch, appType, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceSubscriptionResource>(Response.FromValue(new ServiceWorkspaceSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the subscription of specified user to the specified product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="subscriptionCreateParameters"> Create parameters. </param>
        /// <param name="notify">
        /// Notify change in Subscription State.
        ///  - If false, do not send any email notification for change of state of subscription
        ///  - If true, send email notification of change of state of subscription
        /// </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="appType"> Determines the type of application which send the create user request. Default is legacy publisher portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> or <paramref name="subscriptionCreateParameters"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string sid, SubscriptionCreateParameters subscriptionCreateParameters, bool? notify = null, ETag? ifMatch = null, AppType? appType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));
            Argument.AssertNotNull(subscriptionCreateParameters, nameof(subscriptionCreateParameters));

            using var scope = _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics.CreateScope("ServiceWorkspaceSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, subscriptionCreateParameters, notify, ifMatch, appType, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceSubscriptionResource>(Response.FromValue(new ServiceWorkspaceSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified Subscription entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceSubscriptionResource>> GetAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics.CreateScope("ServiceWorkspaceSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Subscription entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual Response<ServiceWorkspaceSubscriptionResource> Get(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics.CreateScope("ServiceWorkspaceSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all subscriptions of the workspace in an API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| stateComment | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| ownerId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| scope | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| productId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| user | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspaceSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspaceSubscriptionResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceSubscriptionResource(Client, SubscriptionContractData.DeserializeSubscriptionContractData(e)), _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics, Pipeline, "ServiceWorkspaceSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all subscriptions of the workspace in an API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| stateComment | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| ownerId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| scope | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| productId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| user | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspaceSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspaceSubscriptionResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceSubscriptionResource(Client, SubscriptionContractData.DeserializeSubscriptionContractData(e)), _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics, Pipeline, "ServiceWorkspaceSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics.CreateScope("ServiceWorkspaceSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual Response<bool> Exists(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _serviceWorkspaceSubscriptionWorkspaceSubscriptionClientDiagnostics.CreateScope("ServiceWorkspaceSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceSubscriptionWorkspaceSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspaceSubscriptionResource> IEnumerable<ServiceWorkspaceSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspaceSubscriptionResource> IAsyncEnumerable<ServiceWorkspaceSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
