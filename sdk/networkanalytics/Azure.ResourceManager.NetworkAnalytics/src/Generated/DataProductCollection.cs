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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="DataProductResource"/> and their operations.
    /// Each <see cref="DataProductResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DataProductCollection"/> instance call the GetDataProducts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DataProductCollection : ArmCollection, IEnumerable<DataProductResource>, IAsyncEnumerable<DataProductResource>
    {
        private readonly ClientDiagnostics _dataProductClientDiagnostics;
        private readonly DataProductsRestOperations _dataProductRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataProductCollection"/> class for mocking. </summary>
        protected DataProductCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataProductCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataProductCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataProductClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkAnalytics", DataProductResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataProductResource.ResourceType, out string dataProductApiVersion);
            _dataProductRestClient = new DataProductsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataProductApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create data product resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_Create</description>
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
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataProductName"> The data product resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataProductResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataProductName, DataProductData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataProductRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkAnalyticsArmOperation<DataProductResource>(new DataProductOperationSource(Client), _dataProductClientDiagnostics, Pipeline, _dataProductRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create data product resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_Create</description>
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
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataProductName"> The data product resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataProductResource> CreateOrUpdate(WaitUntil waitUntil, string dataProductName, DataProductData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataProductRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, data, cancellationToken);
                var operation = new NetworkAnalyticsArmOperation<DataProductResource>(new DataProductOperationSource(Client), _dataProductClientDiagnostics, Pipeline, _dataProductRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        public virtual async Task<Response<DataProductResource>> GetAsync(string dataProductName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        public virtual Response<DataProductResource> Get(string dataProductName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.Get");
            scope.Start();
            try
            {
                var response = _dataProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List data products by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_ListByResourceGroup</description>
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProductResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProductResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProductRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProductRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProductResource(Client, DataProductData.DeserializeDataProductData(e)), _dataProductClientDiagnostics, Pipeline, "DataProductCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List data products by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_ListByResourceGroup</description>
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProductResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProductResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProductRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProductRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProductResource(Client, DataProductData.DeserializeDataProductData(e)), _dataProductClientDiagnostics, Pipeline, "DataProductCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataProductName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataProductName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, cancellationToken: cancellationToken);
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
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataProductResource>> GetIfExistsAsync(string dataProductName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataProductResource>(response.GetRawResponse());
                return Response.FromValue(new DataProductResource(Client, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="dataProductName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/> is null. </exception>
        public virtual NullableResponse<DataProductResource> GetIfExists(string dataProductName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataProductName, nameof(dataProductName));

            using var scope = _dataProductClientDiagnostics.CreateScope("DataProductCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataProductName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataProductResource>(response.GetRawResponse());
                return Response.FromValue(new DataProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataProductResource> IEnumerable<DataProductResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataProductResource> IAsyncEnumerable<DataProductResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
