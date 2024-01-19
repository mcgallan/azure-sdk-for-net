// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDevCenterResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDevCenterResourceGroupResource"/> class for mocking. </summary>
        protected MockableDevCenterResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDevCenterResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDevCenterResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DevCenterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevCenterResources and their operations over a DevCenterResource. </returns>
        public virtual DevCenterCollection GetDevCenters()
        {
            return GetCachedClient(client => new DevCenterCollection(client, Id));
        }

        /// <summary>
        /// Gets a devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DevCenterResource>> GetDevCenterAsync(string devCenterName, CancellationToken cancellationToken = default)
        {
            return await GetDevCenters().GetAsync(devCenterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DevCenterResource> GetDevCenter(string devCenterName, CancellationToken cancellationToken = default)
        {
            return GetDevCenters().Get(devCenterName, cancellationToken);
        }

        /// <summary> Gets a collection of DevCenterProjectResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevCenterProjectResources and their operations over a DevCenterProjectResource. </returns>
        public virtual DevCenterProjectCollection GetDevCenterProjects()
        {
            return GetCachedClient(client => new DevCenterProjectCollection(client, Id));
        }

        /// <summary>
        /// Gets a specific project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DevCenterProjectResource>> GetDevCenterProjectAsync(string projectName, CancellationToken cancellationToken = default)
        {
            return await GetDevCenterProjects().GetAsync(projectName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a specific project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DevCenterProjectResource> GetDevCenterProject(string projectName, CancellationToken cancellationToken = default)
        {
            return GetDevCenterProjects().Get(projectName, cancellationToken);
        }

        /// <summary> Gets a collection of DevCenterNetworkConnectionResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevCenterNetworkConnectionResources and their operations over a DevCenterNetworkConnectionResource. </returns>
        public virtual DevCenterNetworkConnectionCollection GetDevCenterNetworkConnections()
        {
            return GetCachedClient(client => new DevCenterNetworkConnectionCollection(client, Id));
        }

        /// <summary>
        /// Gets a network connection resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/networkConnections/{networkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterNetworkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkConnectionName"> Name of the Network Connection that can be applied to a Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="networkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DevCenterNetworkConnectionResource>> GetDevCenterNetworkConnectionAsync(string networkConnectionName, CancellationToken cancellationToken = default)
        {
            return await GetDevCenterNetworkConnections().GetAsync(networkConnectionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a network connection resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/networkConnections/{networkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterNetworkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkConnectionName"> Name of the Network Connection that can be applied to a Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="networkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DevCenterNetworkConnectionResource> GetDevCenterNetworkConnection(string networkConnectionName, CancellationToken cancellationToken = default)
        {
            return GetDevCenterNetworkConnections().Get(networkConnectionName, cancellationToken);
        }
    }
}
