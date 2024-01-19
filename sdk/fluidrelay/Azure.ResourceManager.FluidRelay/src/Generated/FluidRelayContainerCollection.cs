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

namespace Azure.ResourceManager.FluidRelay
{
    /// <summary>
    /// A class representing a collection of <see cref="FluidRelayContainerResource"/> and their operations.
    /// Each <see cref="FluidRelayContainerResource"/> in the collection will belong to the same instance of <see cref="FluidRelayServerResource"/>.
    /// To get a <see cref="FluidRelayContainerCollection"/> instance call the GetFluidRelayContainers method from an instance of <see cref="FluidRelayServerResource"/>.
    /// </summary>
    public partial class FluidRelayContainerCollection : ArmCollection, IEnumerable<FluidRelayContainerResource>, IAsyncEnumerable<FluidRelayContainerResource>
    {
        private readonly ClientDiagnostics _fluidRelayContainerClientDiagnostics;
        private readonly FluidRelayContainersRestOperations _fluidRelayContainerRestClient;

        /// <summary> Initializes a new instance of the <see cref="FluidRelayContainerCollection"/> class for mocking. </summary>
        protected FluidRelayContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FluidRelayContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FluidRelayContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fluidRelayContainerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FluidRelay", FluidRelayContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FluidRelayContainerResource.ResourceType, out string fluidRelayContainerApiVersion);
            _fluidRelayContainerRestClient = new FluidRelayContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fluidRelayContainerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FluidRelayServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FluidRelayServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Fluid Relay container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers/{fluidRelayContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayContainerName"> The Fluid Relay container resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayContainerName"/> is null. </exception>
        public virtual async Task<Response<FluidRelayContainerResource>> GetAsync(string fluidRelayContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayContainerName, nameof(fluidRelayContainerName));

            using var scope = _fluidRelayContainerClientDiagnostics.CreateScope("FluidRelayContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _fluidRelayContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fluidRelayContainerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FluidRelayContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Fluid Relay container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers/{fluidRelayContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayContainerName"> The Fluid Relay container resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayContainerName"/> is null. </exception>
        public virtual Response<FluidRelayContainerResource> Get(string fluidRelayContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayContainerName, nameof(fluidRelayContainerName));

            using var scope = _fluidRelayContainerClientDiagnostics.CreateScope("FluidRelayContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _fluidRelayContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fluidRelayContainerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FluidRelayContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Fluid Relay containers which are children of a given Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_ListByFluidRelayServers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FluidRelayContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FluidRelayContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fluidRelayContainerRestClient.CreateListByFluidRelayServersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fluidRelayContainerRestClient.CreateListByFluidRelayServersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FluidRelayContainerResource(Client, FluidRelayContainerData.DeserializeFluidRelayContainerData(e)), _fluidRelayContainerClientDiagnostics, Pipeline, "FluidRelayContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Fluid Relay containers which are children of a given Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_ListByFluidRelayServers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FluidRelayContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FluidRelayContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fluidRelayContainerRestClient.CreateListByFluidRelayServersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fluidRelayContainerRestClient.CreateListByFluidRelayServersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FluidRelayContainerResource(Client, FluidRelayContainerData.DeserializeFluidRelayContainerData(e)), _fluidRelayContainerClientDiagnostics, Pipeline, "FluidRelayContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers/{fluidRelayContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayContainerName"> The Fluid Relay container resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayContainerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fluidRelayContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayContainerName, nameof(fluidRelayContainerName));

            using var scope = _fluidRelayContainerClientDiagnostics.CreateScope("FluidRelayContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _fluidRelayContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fluidRelayContainerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers/{fluidRelayContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayContainerName"> The Fluid Relay container resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayContainerName"/> is null. </exception>
        public virtual Response<bool> Exists(string fluidRelayContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayContainerName, nameof(fluidRelayContainerName));

            using var scope = _fluidRelayContainerClientDiagnostics.CreateScope("FluidRelayContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _fluidRelayContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fluidRelayContainerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers/{fluidRelayContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayContainerName"> The Fluid Relay container resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayContainerName"/> is null. </exception>
        public virtual async Task<NullableResponse<FluidRelayContainerResource>> GetIfExistsAsync(string fluidRelayContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayContainerName, nameof(fluidRelayContainerName));

            using var scope = _fluidRelayContainerClientDiagnostics.CreateScope("FluidRelayContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fluidRelayContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fluidRelayContainerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FluidRelayContainerResource>(response.GetRawResponse());
                return Response.FromValue(new FluidRelayContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}/fluidRelayContainers/{fluidRelayContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayContainerName"> The Fluid Relay container resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayContainerName"/> is null. </exception>
        public virtual NullableResponse<FluidRelayContainerResource> GetIfExists(string fluidRelayContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayContainerName, nameof(fluidRelayContainerName));

            using var scope = _fluidRelayContainerClientDiagnostics.CreateScope("FluidRelayContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fluidRelayContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fluidRelayContainerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FluidRelayContainerResource>(response.GetRawResponse());
                return Response.FromValue(new FluidRelayContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FluidRelayContainerResource> IEnumerable<FluidRelayContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FluidRelayContainerResource> IAsyncEnumerable<FluidRelayContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
