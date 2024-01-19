// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementDeletedServiceResource"/> and their operations.
    /// Each <see cref="ApiManagementDeletedServiceResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get an <see cref="ApiManagementDeletedServiceCollection"/> instance call the GetApiManagementDeletedServices method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class ApiManagementDeletedServiceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _apiManagementDeletedServiceDeletedServicesClientDiagnostics;
        private readonly DeletedServicesRestOperations _apiManagementDeletedServiceDeletedServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementDeletedServiceCollection"/> class for mocking. </summary>
        protected ApiManagementDeletedServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementDeletedServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementDeletedServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementDeletedServiceDeletedServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementDeletedServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementDeletedServiceResource.ResourceType, out string apiManagementDeletedServiceDeletedServicesApiVersion);
            _apiManagementDeletedServiceDeletedServicesRestClient = new DeletedServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementDeletedServiceDeletedServicesApiVersion);
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
        /// Get soft-deleted Api Management Service by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/locations/{location}/deletedservices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementDeletedServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted API Management service. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<ApiManagementDeletedServiceResource>> GetAsync(AzureLocation location, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("ApiManagementDeletedServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementDeletedServiceDeletedServicesRestClient.GetByNameAsync(Id.SubscriptionId, location, serviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementDeletedServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get soft-deleted Api Management Service by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/locations/{location}/deletedservices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementDeletedServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted API Management service. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<ApiManagementDeletedServiceResource> Get(AzureLocation location, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("ApiManagementDeletedServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementDeletedServiceDeletedServicesRestClient.GetByName(Id.SubscriptionId, location, serviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementDeletedServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/locations/{location}/deletedservices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementDeletedServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted API Management service. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("ApiManagementDeletedServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementDeletedServiceDeletedServicesRestClient.GetByNameAsync(Id.SubscriptionId, location, serviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/locations/{location}/deletedservices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementDeletedServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted API Management service. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation location, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("ApiManagementDeletedServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementDeletedServiceDeletedServicesRestClient.GetByName(Id.SubscriptionId, location, serviceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/locations/{location}/deletedservices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementDeletedServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted API Management service. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementDeletedServiceResource>> GetIfExistsAsync(AzureLocation location, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("ApiManagementDeletedServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementDeletedServiceDeletedServicesRestClient.GetByNameAsync(Id.SubscriptionId, location, serviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementDeletedServiceResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementDeletedServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/locations/{location}/deletedservices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_GetByName</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementDeletedServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted API Management service. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual NullableResponse<ApiManagementDeletedServiceResource> GetIfExists(AzureLocation location, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("ApiManagementDeletedServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementDeletedServiceDeletedServicesRestClient.GetByName(Id.SubscriptionId, location, serviceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementDeletedServiceResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementDeletedServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
