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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing a ServiceWorkspacePolicyFragment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServiceWorkspacePolicyFragmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServiceWorkspacePolicyFragmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="WorkspaceContractResource" /> using the GetServiceWorkspacePolicyFragment method.
    /// </summary>
    public partial class ServiceWorkspacePolicyFragmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceWorkspacePolicyFragmentResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string workspaceId, string id)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics;
        private readonly WorkspacePolicyFragmentRestOperations _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient;
        private readonly PolicyFragmentContractData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspacePolicyFragmentResource"/> class for mocking. </summary>
        protected ServiceWorkspacePolicyFragmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceWorkspacePolicyFragmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceWorkspacePolicyFragmentResource(ArmClient client, PolicyFragmentContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspacePolicyFragmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceWorkspacePolicyFragmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceWorkspacePolicyFragmentWorkspacePolicyFragmentApiVersion);
            _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient = new WorkspacePolicyFragmentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspacePolicyFragmentWorkspacePolicyFragmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/workspaces/policyFragments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyFragmentContractData Data
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

        /// <summary>
        /// Gets a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceWorkspacePolicyFragmentResource>> GetAsync(PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, format, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspacePolicyFragmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceWorkspacePolicyFragmentResource> Get(PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, format, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspacePolicyFragmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
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
        /// Deletes a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
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
        /// Creates or updates a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The policy fragment contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspacePolicyFragmentResource>> UpdateAsync(WaitUntil waitUntil, PolicyFragmentContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceWorkspacePolicyFragmentResource>(new ServiceWorkspacePolicyFragmentOperationSource(Client), _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics, Pipeline, _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The policy fragment contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspacePolicyFragmentResource> Update(WaitUntil waitUntil, PolicyFragmentContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.Update");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceWorkspacePolicyFragmentResource>(new ServiceWorkspacePolicyFragmentOperationSource(Client), _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics, Pipeline, _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Lists policy resources that reference the policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}/listReferences</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_ListReferences</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceCollectionValueItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceCollectionValueItem> GetReferencesAsync(int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.CreateListReferencesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, top, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ResourceCollectionValueItem.DeserializeResourceCollectionValueItem, _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics, Pipeline, "ServiceWorkspacePolicyFragmentResource.GetReferences", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists policy resources that reference the policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}/listReferences</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_ListReferences</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceCollectionValueItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceCollectionValueItem> GetReferences(int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.CreateListReferencesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, top, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, ResourceCollectionValueItem.DeserializeResourceCollectionValueItem, _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics, Pipeline, "ServiceWorkspacePolicyFragmentResource.GetReferences", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the entity state (Etag) version of a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicyFragment_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentClientDiagnostics.CreateScope("ServiceWorkspacePolicyFragmentResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyFragmentWorkspacePolicyFragmentRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
