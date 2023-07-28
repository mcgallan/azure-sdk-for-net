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
    /// A Class representing a PortalConfigContract along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PortalConfigContractResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPortalConfigContractResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource" /> using the GetPortalConfigContract method.
    /// </summary>
    public partial class PortalConfigContractResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PortalConfigContractResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string portalConfigId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _portalConfigContractPortalConfigClientDiagnostics;
        private readonly PortalConfigRestOperations _portalConfigContractPortalConfigRestClient;
        private readonly PortalConfigContractData _data;

        /// <summary> Initializes a new instance of the <see cref="PortalConfigContractResource"/> class for mocking. </summary>
        protected PortalConfigContractResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PortalConfigContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PortalConfigContractResource(ArmClient client, PortalConfigContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PortalConfigContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PortalConfigContractResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _portalConfigContractPortalConfigClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string portalConfigContractPortalConfigApiVersion);
            _portalConfigContractPortalConfigRestClient = new PortalConfigRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, portalConfigContractPortalConfigApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/portalconfigs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PortalConfigContractData Data
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
        /// Get the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PortalConfigContractResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractResource.Get");
            scope.Start();
            try
            {
                var response = await _portalConfigContractPortalConfigRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PortalConfigContractResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractResource.Get");
            scope.Start();
            try
            {
                var response = _portalConfigContractPortalConfigRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update the developer portal configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<PortalConfigContractResource>> UpdateAsync(ETag ifMatch, PortalConfigContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractResource.Update");
            scope.Start();
            try
            {
                var response = await _portalConfigContractPortalConfigRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update the developer portal configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<PortalConfigContractResource> Update(ETag ifMatch, PortalConfigContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractResource.Update");
            scope.Start();
            try
            {
                var response = _portalConfigContractPortalConfigRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, data, cancellationToken);
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _portalConfigContractPortalConfigRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _portalConfigContractPortalConfigRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
