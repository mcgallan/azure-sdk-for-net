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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an AuthorizationProviderContract along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AuthorizationProviderContractResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAuthorizationProviderContractResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource" /> using the GetAuthorizationProviderContract method.
    /// </summary>
    public partial class AuthorizationProviderContractResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AuthorizationProviderContractResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string authorizationProviderId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _authorizationProviderContractAuthorizationProviderClientDiagnostics;
        private readonly AuthorizationProviderRestOperations _authorizationProviderContractAuthorizationProviderRestClient;
        private readonly AuthorizationProviderContractData _data;

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderContractResource"/> class for mocking. </summary>
        protected AuthorizationProviderContractResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AuthorizationProviderContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AuthorizationProviderContractResource(ArmClient client, AuthorizationProviderContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AuthorizationProviderContractResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _authorizationProviderContractAuthorizationProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string authorizationProviderContractAuthorizationProviderApiVersion);
            _authorizationProviderContractAuthorizationProviderRestClient = new AuthorizationProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, authorizationProviderContractAuthorizationProviderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/authorizationProviders";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AuthorizationProviderContractData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of AuthorizationContractResources in the AuthorizationProviderContract. </summary>
        /// <returns> An object representing collection of AuthorizationContractResources and their operations over a AuthorizationContractResource. </returns>
        public virtual AuthorizationContractCollection GetAuthorizationContracts()
        {
            return GetCachedClient(Client => new AuthorizationContractCollection(Client, Id));
        }

        /// <summary>
        /// Gets the details of the authorization specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}/authorizations/{authorizationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorization_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationId"> Identifier of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AuthorizationContractResource>> GetAuthorizationContractAsync(string authorizationId, CancellationToken cancellationToken = default)
        {
            return await GetAuthorizationContracts().GetAsync(authorizationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the authorization specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}/authorizations/{authorizationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorization_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationId"> Identifier of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<AuthorizationContractResource> GetAuthorizationContract(string authorizationId, CancellationToken cancellationToken = default)
        {
            return GetAuthorizationContracts().Get(authorizationId, cancellationToken);
        }

        /// <summary>
        /// Gets the details of the authorization provider specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AuthorizationProviderContractResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractResource.Get");
            scope.Start();
            try
            {
                var response = await _authorizationProviderContractAuthorizationProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the authorization provider specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AuthorizationProviderContractResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractResource.Get");
            scope.Start();
            try
            {
                var response = _authorizationProviderContractAuthorizationProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes specific authorization provider from the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractResource.Delete");
            scope.Start();
            try
            {
                var response = await _authorizationProviderContractAuthorizationProviderRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes specific authorization provider from the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractResource.Delete");
            scope.Start();
            try
            {
                var response = _authorizationProviderContractAuthorizationProviderRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates authorization provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AuthorizationProviderContractResource>> UpdateAsync(WaitUntil waitUntil, AuthorizationProviderContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractResource.Update");
            scope.Start();
            try
            {
                var response = await _authorizationProviderContractAuthorizationProviderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<AuthorizationProviderContractResource>(Response.FromValue(new AuthorizationProviderContractResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates authorization provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AuthorizationProviderContractResource> Update(WaitUntil waitUntil, AuthorizationProviderContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractResource.Update");
            scope.Start();
            try
            {
                var response = _authorizationProviderContractAuthorizationProviderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<AuthorizationProviderContractResource>(Response.FromValue(new AuthorizationProviderContractResource(Client, response), response.GetRawResponse()));
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
    }
}
