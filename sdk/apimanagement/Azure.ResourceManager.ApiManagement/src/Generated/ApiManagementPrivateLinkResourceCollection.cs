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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementPrivateLinkResource"/> and their operations.
    /// Each <see cref="ApiManagementPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiManagementPrivateLinkResourceCollection"/> instance call the GetApiManagementPrivateLinkResources method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiManagementPrivateLinkResourceCollection : ArmCollection, IEnumerable<ApiManagementPrivateLinkResource>, IAsyncEnumerable<ApiManagementPrivateLinkResource>
    {
        private readonly ClientDiagnostics _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics;
        private readonly PrivateEndpointConnectionRestOperations _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected ApiManagementPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementPrivateLinkResource.ResourceType, out string apiManagementPrivateLinkResourcePrivateEndpointConnectionApiVersion);
            _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient = new PrivateEndpointConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementPrivateLinkResourcePrivateEndpointConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the private link resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources/{privateLinkSubResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_GetPrivateLinkResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkSubResourceName"> Name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkSubResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkSubResourceName"/> is null. </exception>
        public virtual async Task<Response<ApiManagementPrivateLinkResource>> GetAsync(string privateLinkSubResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkSubResourceName, nameof(privateLinkSubResourceName));

            using var scope = _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics.CreateScope("ApiManagementPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.GetPrivateLinkResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkSubResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources/{privateLinkSubResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_GetPrivateLinkResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkSubResourceName"> Name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkSubResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkSubResourceName"/> is null. </exception>
        public virtual Response<ApiManagementPrivateLinkResource> Get(string privateLinkSubResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkSubResourceName, nameof(privateLinkSubResourceName));

            using var scope = _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics.CreateScope("ApiManagementPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.GetPrivateLinkResource(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkSubResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_ListPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.CreateListPrivateLinkResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ApiManagementPrivateLinkResource(Client, ApiManagementPrivateLinkResourceData.DeserializeApiManagementPrivateLinkResourceData(e)), _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics, Pipeline, "ApiManagementPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the private link resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_ListPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.CreateListPrivateLinkResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ApiManagementPrivateLinkResource(Client, ApiManagementPrivateLinkResourceData.DeserializeApiManagementPrivateLinkResourceData(e)), _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics, Pipeline, "ApiManagementPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources/{privateLinkSubResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_GetPrivateLinkResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkSubResourceName"> Name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkSubResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkSubResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateLinkSubResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkSubResourceName, nameof(privateLinkSubResourceName));

            using var scope = _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics.CreateScope("ApiManagementPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.GetPrivateLinkResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkSubResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources/{privateLinkSubResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_GetPrivateLinkResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkSubResourceName"> Name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkSubResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkSubResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateLinkSubResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkSubResourceName, nameof(privateLinkSubResourceName));

            using var scope = _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics.CreateScope("ApiManagementPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.GetPrivateLinkResource(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkSubResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources/{privateLinkSubResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_GetPrivateLinkResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkSubResourceName"> Name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkSubResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkSubResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementPrivateLinkResource>> GetIfExistsAsync(string privateLinkSubResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkSubResourceName, nameof(privateLinkSubResourceName));

            using var scope = _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics.CreateScope("ApiManagementPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.GetPrivateLinkResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkSubResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/privateLinkResources/{privateLinkSubResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_GetPrivateLinkResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkSubResourceName"> Name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkSubResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkSubResourceName"/> is null. </exception>
        public virtual NullableResponse<ApiManagementPrivateLinkResource> GetIfExists(string privateLinkSubResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkSubResourceName, nameof(privateLinkSubResourceName));

            using var scope = _apiManagementPrivateLinkResourcePrivateEndpointConnectionClientDiagnostics.CreateScope("ApiManagementPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementPrivateLinkResourcePrivateEndpointConnectionRestClient.GetPrivateLinkResource(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkSubResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementPrivateLinkResource> IEnumerable<ApiManagementPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementPrivateLinkResource> IAsyncEnumerable<ApiManagementPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
