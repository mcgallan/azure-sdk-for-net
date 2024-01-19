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
using Azure.ResourceManager.NetworkAnalytics;

namespace Azure.ResourceManager.NetworkAnalytics.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableNetworkAnalyticsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableNetworkAnalyticsResourceGroupResource"/> class for mocking. </summary>
        protected MockableNetworkAnalyticsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNetworkAnalyticsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNetworkAnalyticsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DataProductResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataProductResources and their operations over a DataProductResource. </returns>
        public virtual DataProductCollection GetDataProducts()
        {
            return GetCachedClient(client => new DataProductCollection(client, Id));
        }

        /// <summary>
        /// Retrieve data product resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataProductName"> The data product resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataProductResource>> GetDataProductAsync(string dataProductName, CancellationToken cancellationToken = default)
        {
            return await GetDataProducts().GetAsync(dataProductName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve data product resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataProductName"> The data product resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataProductResource> GetDataProduct(string dataProductName, CancellationToken cancellationToken = default)
        {
            return GetDataProducts().Get(dataProductName, cancellationToken);
        }

        /// <summary> Gets an object representing a DataProductsCatalogResource along with the instance operations that can be performed on it in the ResourceGroupResource. </summary>
        /// <returns> Returns a <see cref="DataProductsCatalogResource"/> object. </returns>
        public virtual DataProductsCatalogResource GetDataProductsCatalog()
        {
            return new DataProductsCatalogResource(Client, Id.AppendProviderResource("Microsoft.NetworkAnalytics", "dataProductsCatalogs", "default"));
        }
    }
}
