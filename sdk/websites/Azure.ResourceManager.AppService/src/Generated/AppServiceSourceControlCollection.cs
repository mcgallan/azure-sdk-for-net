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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppServiceSourceControlResource"/> and their operations.
    /// Each <see cref="AppServiceSourceControlResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get an <see cref="AppServiceSourceControlCollection"/> instance call the GetAppServiceSourceControls method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class AppServiceSourceControlCollection : ArmCollection, IEnumerable<AppServiceSourceControlResource>, IAsyncEnumerable<AppServiceSourceControlResource>
    {
        private readonly ClientDiagnostics _appServiceSourceControlClientDiagnostics;
        private readonly WebSiteManagementRestOperations _appServiceSourceControlRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceSourceControlCollection"/> class for mocking. </summary>
        protected AppServiceSourceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceSourceControlCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceSourceControlCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceSourceControlClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceSourceControlResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppServiceSourceControlResource.ResourceType, out string appServiceSourceControlApiVersion);
            _appServiceSourceControlRestClient = new WebSiteManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServiceSourceControlApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Updates source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="data"> Source control token information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceSourceControlResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sourceControlType, AppServiceSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceSourceControlRestClient.UpdateSourceControlAsync(sourceControlType, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServiceSourceControlResource>(Response.FromValue(new AppServiceSourceControlResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="data"> Source control token information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServiceSourceControlResource> CreateOrUpdate(WaitUntil waitUntil, string sourceControlType, AppServiceSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceSourceControlRestClient.UpdateSourceControl(sourceControlType, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppServiceSourceControlResource>(Response.FromValue(new AppServiceSourceControlResource(Client, response), response.GetRawResponse()));
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
        /// Description for Gets source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual async Task<Response<AppServiceSourceControlResource>> GetAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceSourceControlRestClient.GetSourceControlAsync(sourceControlType, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<AppServiceSourceControlResource> Get(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceSourceControlRestClient.GetSourceControl(sourceControlType, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the source controls available for Azure websites.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListSourceControls</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceSourceControlResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceSourceControlResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceSourceControlRestClient.CreateListSourceControlsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceSourceControlRestClient.CreateListSourceControlsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppServiceSourceControlResource(Client, AppServiceSourceControlData.DeserializeAppServiceSourceControlData(e)), _appServiceSourceControlClientDiagnostics, Pipeline, "AppServiceSourceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the source controls available for Azure websites.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListSourceControls</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceSourceControlResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceSourceControlResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceSourceControlRestClient.CreateListSourceControlsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceSourceControlRestClient.CreateListSourceControlsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppServiceSourceControlResource(Client, AppServiceSourceControlData.DeserializeAppServiceSourceControlData(e)), _appServiceSourceControlClientDiagnostics, Pipeline, "AppServiceSourceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appServiceSourceControlRestClient.GetSourceControlAsync(sourceControlType, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = _appServiceSourceControlRestClient.GetSourceControl(sourceControlType, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual async Task<NullableResponse<AppServiceSourceControlResource>> GetIfExistsAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServiceSourceControlRestClient.GetSourceControlAsync(sourceControlType, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppServiceSourceControlResource>(response.GetRawResponse());
                return Response.FromValue(new AppServiceSourceControlResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual NullableResponse<AppServiceSourceControlResource> GetIfExists(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceSourceControlRestClient.GetSourceControl(sourceControlType, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppServiceSourceControlResource>(response.GetRawResponse());
                return Response.FromValue(new AppServiceSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceSourceControlResource> IEnumerable<AppServiceSourceControlResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceSourceControlResource> IAsyncEnumerable<AppServiceSourceControlResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
