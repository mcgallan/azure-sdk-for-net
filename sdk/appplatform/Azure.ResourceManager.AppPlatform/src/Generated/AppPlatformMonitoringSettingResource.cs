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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an AppPlatformMonitoringSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppPlatformMonitoringSettingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppPlatformMonitoringSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformServiceResource"/> using the GetAppPlatformMonitoringSetting method.
    /// </summary>
    public partial class AppPlatformMonitoringSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppPlatformMonitoringSettingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/monitoringSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics;
        private readonly MonitoringSettingsRestOperations _appPlatformMonitoringSettingMonitoringSettingsRestClient;
        private readonly AppPlatformMonitoringSettingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/monitoringSettings";

        /// <summary> Initializes a new instance of the <see cref="AppPlatformMonitoringSettingResource"/> class for mocking. </summary>
        protected AppPlatformMonitoringSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformMonitoringSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppPlatformMonitoringSettingResource(ArmClient client, AppPlatformMonitoringSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformMonitoringSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformMonitoringSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appPlatformMonitoringSettingMonitoringSettingsApiVersion);
            _appPlatformMonitoringSettingMonitoringSettingsRestClient = new MonitoringSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformMonitoringSettingMonitoringSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppPlatformMonitoringSettingData Data
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
        /// Get the Monitoring Setting and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/monitoringSettings/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoringSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformMonitoringSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformMonitoringSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics.CreateScope("AppPlatformMonitoringSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformMonitoringSettingMonitoringSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformMonitoringSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Monitoring Setting and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/monitoringSettings/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoringSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformMonitoringSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformMonitoringSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics.CreateScope("AppPlatformMonitoringSettingResource.Get");
            scope.Start();
            try
            {
                var response = _appPlatformMonitoringSettingMonitoringSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformMonitoringSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the Monitoring Setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/monitoringSettings/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoringSettings_UpdatePatch</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformMonitoringSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformMonitoringSettingResource>> UpdateAsync(WaitUntil waitUntil, AppPlatformMonitoringSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics.CreateScope("AppPlatformMonitoringSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _appPlatformMonitoringSettingMonitoringSettingsRestClient.UpdatePatchAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformMonitoringSettingResource>(new AppPlatformMonitoringSettingOperationSource(Client), _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics, Pipeline, _appPlatformMonitoringSettingMonitoringSettingsRestClient.CreateUpdatePatchRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the Monitoring Setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/monitoringSettings/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoringSettings_UpdatePatch</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformMonitoringSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformMonitoringSettingResource> Update(WaitUntil waitUntil, AppPlatformMonitoringSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics.CreateScope("AppPlatformMonitoringSettingResource.Update");
            scope.Start();
            try
            {
                var response = _appPlatformMonitoringSettingMonitoringSettingsRestClient.UpdatePatch(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformMonitoringSettingResource>(new AppPlatformMonitoringSettingOperationSource(Client), _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics, Pipeline, _appPlatformMonitoringSettingMonitoringSettingsRestClient.CreateUpdatePatchRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the Monitoring Setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/monitoringSettings/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoringSettings_UpdatePut</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformMonitoringSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformMonitoringSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AppPlatformMonitoringSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics.CreateScope("AppPlatformMonitoringSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformMonitoringSettingMonitoringSettingsRestClient.UpdatePutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformMonitoringSettingResource>(new AppPlatformMonitoringSettingOperationSource(Client), _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics, Pipeline, _appPlatformMonitoringSettingMonitoringSettingsRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the Monitoring Setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/monitoringSettings/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoringSettings_UpdatePut</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformMonitoringSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformMonitoringSettingResource> CreateOrUpdate(WaitUntil waitUntil, AppPlatformMonitoringSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics.CreateScope("AppPlatformMonitoringSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformMonitoringSettingMonitoringSettingsRestClient.UpdatePut(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformMonitoringSettingResource>(new AppPlatformMonitoringSettingOperationSource(Client), _appPlatformMonitoringSettingMonitoringSettingsClientDiagnostics, Pipeline, _appPlatformMonitoringSettingMonitoringSettingsRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
