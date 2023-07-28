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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ResolverContractResource" /> and their operations.
    /// Each <see cref="ResolverContractResource" /> in the collection will belong to the same instance of <see cref="ServiceApiResource" />.
    /// To get a <see cref="ResolverContractCollection" /> instance call the GetResolverContracts method from an instance of <see cref="ServiceApiResource" />.
    /// </summary>
    public partial class ResolverContractCollection : ArmCollection, IEnumerable<ResolverContractResource>, IAsyncEnumerable<ResolverContractResource>
    {
        private readonly ClientDiagnostics _resolverContractGraphQLApiResolverClientDiagnostics;
        private readonly GraphQLApiResolverRestOperations _resolverContractGraphQLApiResolverRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResolverContractCollection"/> class for mocking. </summary>
        protected ResolverContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResolverContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResolverContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resolverContractGraphQLApiResolverClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResolverContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResolverContractResource.ResourceType, out string resolverContractGraphQLApiResolverApiVersion);
            _resolverContractGraphQLApiResolverRestClient = new GraphQLApiResolverRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resolverContractGraphQLApiResolverApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceApiResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceApiResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new resolver in the GraphQL API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resolverId"> Resolver identifier within a GraphQL API. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resolverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resolverId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResolverContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resolverId, ResolverContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resolverId, nameof(resolverId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resolverContractGraphQLApiResolverRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, resolverId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ResolverContractResource>(Response.FromValue(new ResolverContractResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new resolver in the GraphQL API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resolverId"> Resolver identifier within a GraphQL API. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resolverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resolverId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResolverContractResource> CreateOrUpdate(WaitUntil waitUntil, string resolverId, ResolverContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resolverId, nameof(resolverId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resolverContractGraphQLApiResolverRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, resolverId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ResolverContractResource>(Response.FromValue(new ResolverContractResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the GraphQL API Resolver specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resolverId"> Resolver identifier within a GraphQL API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resolverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resolverId"/> is null. </exception>
        public virtual async Task<Response<ResolverContractResource>> GetAsync(string resolverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resolverId, nameof(resolverId));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _resolverContractGraphQLApiResolverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, resolverId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResolverContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the GraphQL API Resolver specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resolverId"> Resolver identifier within a GraphQL API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resolverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resolverId"/> is null. </exception>
        public virtual Response<ResolverContractResource> Get(string resolverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resolverId, nameof(resolverId));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractCollection.Get");
            scope.Start();
            try
            {
                var response = _resolverContractGraphQLApiResolverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, resolverId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResolverContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of the resolvers for the specified GraphQL API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_ListByApi</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| path | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResolverContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResolverContractResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resolverContractGraphQLApiResolverRestClient.CreateListByApiRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resolverContractGraphQLApiResolverRestClient.CreateListByApiNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResolverContractResource(Client, ResolverContractData.DeserializeResolverContractData(e)), _resolverContractGraphQLApiResolverClientDiagnostics, Pipeline, "ResolverContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of the resolvers for the specified GraphQL API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_ListByApi</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| path | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResolverContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResolverContractResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resolverContractGraphQLApiResolverRestClient.CreateListByApiRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resolverContractGraphQLApiResolverRestClient.CreateListByApiNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResolverContractResource(Client, ResolverContractData.DeserializeResolverContractData(e)), _resolverContractGraphQLApiResolverClientDiagnostics, Pipeline, "ResolverContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resolverId"> Resolver identifier within a GraphQL API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resolverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resolverId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resolverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resolverId, nameof(resolverId));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resolverContractGraphQLApiResolverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, resolverId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resolverId"> Resolver identifier within a GraphQL API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resolverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resolverId"/> is null. </exception>
        public virtual Response<bool> Exists(string resolverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resolverId, nameof(resolverId));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _resolverContractGraphQLApiResolverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, resolverId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResolverContractResource> IEnumerable<ResolverContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResolverContractResource> IAsyncEnumerable<ResolverContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
