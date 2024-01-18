// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataBox;
using Azure.ResourceManager.DataBox.Models;

namespace Azure.ResourceManager.DataBox.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDataBoxResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _serviceClientDiagnostics;
        private ServiceRestOperations _serviceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDataBoxResourceGroupResource"/> class for mocking. </summary>
        protected MockableDataBoxResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDataBoxResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDataBoxResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ServiceClientDiagnostics => _serviceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataBox", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ServiceRestOperations ServiceRestClient => _serviceRestClient ??= new ServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DataBoxJobResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataBoxJobResources and their operations over a DataBoxJobResource. </returns>
        public virtual DataBoxJobCollection GetDataBoxJobs()
        {
            return GetCachedClient(client => new DataBoxJobCollection(client, Id));
        }

        /// <summary>
        /// Gets information about the specified job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataBoxJobResource>> GetDataBoxJobAsync(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetDataBoxJobs().GetAsync(jobName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataBoxJobResource> GetDataBoxJob(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetDataBoxJobs().Get(jobName, expand, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of available skus for the given subscription, resource group and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ListAvailableSkusByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="DataBoxSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxSkuInformation> GetAvailableSkusAsync(AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceRestClient.CreateListAvailableSkusByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, location, content);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceRestClient.CreateListAvailableSkusByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DataBoxSkuInformation.DeserializeDataBoxSkuInformation, ServiceClientDiagnostics, Pipeline, "MockableDataBoxResourceGroupResource.GetAvailableSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method provides the list of available skus for the given subscription, resource group and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ListAvailableSkusByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="DataBoxSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxSkuInformation> GetAvailableSkus(AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceRestClient.CreateListAvailableSkusByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, location, content);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceRestClient.CreateListAvailableSkusByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DataBoxSkuInformation.DeserializeDataBoxSkuInformation, ServiceClientDiagnostics, Pipeline, "MockableDataBoxResourceGroupResource.GetAvailableSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputsByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<DataBoxValidationResult>> ValidateInputsAsync(AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ServiceClientDiagnostics.CreateScope("MockableDataBoxResourceGroupResource.ValidateInputs");
            scope.Start();
            try
            {
                var response = await ServiceRestClient.ValidateInputsByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputsByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<DataBoxValidationResult> ValidateInputs(AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ServiceClientDiagnostics.CreateScope("MockableDataBoxResourceGroupResource.ValidateInputs");
            scope.Start();
            try
            {
                var response = ServiceRestClient.ValidateInputsByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfigurationByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<RegionConfigurationResult>> GetRegionConfigurationAsync(AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ServiceClientDiagnostics.CreateScope("MockableDataBoxResourceGroupResource.GetRegionConfiguration");
            scope.Start();
            try
            {
                var response = await ServiceRestClient.RegionConfigurationByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfigurationByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<RegionConfigurationResult> GetRegionConfiguration(AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ServiceClientDiagnostics.CreateScope("MockableDataBoxResourceGroupResource.GetRegionConfiguration");
            scope.Start();
            try
            {
                var response = ServiceRestClient.RegionConfigurationByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, location, content, cancellationToken);
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
