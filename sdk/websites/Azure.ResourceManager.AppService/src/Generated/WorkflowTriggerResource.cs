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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WorkflowTrigger along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WorkflowTriggerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWorkflowTriggerResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWorkflowTrigger method.
    /// </summary>
    public partial class WorkflowTriggerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkflowTriggerResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string workflowName, string triggerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workflowTriggerClientDiagnostics;
        private readonly WorkflowTriggersRestOperations _workflowTriggerRestClient;
        private readonly WorkflowTriggerData _data;

        /// <summary> Initializes a new instance of the <see cref="WorkflowTriggerResource"/> class for mocking. </summary>
        protected WorkflowTriggerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WorkflowTriggerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkflowTriggerResource(ArmClient client, WorkflowTriggerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkflowTriggerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkflowTriggerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workflowTriggerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workflowTriggerApiVersion);
            _workflowTriggerRestClient = new WorkflowTriggersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workflowTriggerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/hostruntime/webhooks/api/workflows/triggers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkflowTriggerData Data
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

        /// <summary> Gets a collection of WorkflowTriggerHistoryResources in the WorkflowTrigger. </summary>
        /// <returns> An object representing collection of WorkflowTriggerHistoryResources and their operations over a WorkflowTriggerHistoryResource. </returns>
        public virtual WorkflowTriggerHistoryCollection GetWorkflowTriggerHistories()
        {
            return GetCachedClient(Client => new WorkflowTriggerHistoryCollection(Client, Id));
        }

        /// <summary>
        /// Gets a workflow trigger history.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}
        /// Operation Id: WorkflowTriggerHistories_Get
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WorkflowTriggerHistoryResource>> GetWorkflowTriggerHistoryAsync(string historyName, CancellationToken cancellationToken = default)
        {
            return await GetWorkflowTriggerHistories().GetAsync(historyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow trigger history.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}
        /// Operation Id: WorkflowTriggerHistories_Get
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<WorkflowTriggerHistoryResource> GetWorkflowTriggerHistory(string historyName, CancellationToken cancellationToken = default)
        {
            return GetWorkflowTriggerHistories().Get(historyName, cancellationToken);
        }

        /// <summary>
        /// Gets a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}
        /// Operation Id: WorkflowTriggers_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkflowTriggerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.Get");
            scope.Start();
            try
            {
                var response = await _workflowTriggerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}
        /// Operation Id: WorkflowTriggers_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkflowTriggerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.Get");
            scope.Start();
            try
            {
                var response = _workflowTriggerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the callback URL for a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/listCallbackUrl
        /// Operation Id: WorkflowTriggers_ListCallbackUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkflowTriggerCallbackUri>> GetCallbackUrlAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.GetCallbackUrl");
            scope.Start();
            try
            {
                var response = await _workflowTriggerRestClient.ListCallbackUrlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the callback URL for a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/listCallbackUrl
        /// Operation Id: WorkflowTriggers_ListCallbackUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkflowTriggerCallbackUri> GetCallbackUrl(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.GetCallbackUrl");
            scope.Start();
            try
            {
                var response = _workflowTriggerRestClient.ListCallbackUrl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Runs a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/run
        /// Operation Id: WorkflowTriggers_Run
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> RunAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.Run");
            scope.Start();
            try
            {
                var response = await _workflowTriggerRestClient.RunAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_workflowTriggerClientDiagnostics, Pipeline, _workflowTriggerRestClient.CreateRunRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Runs a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/run
        /// Operation Id: WorkflowTriggers_Run
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Run(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.Run");
            scope.Start();
            try
            {
                var response = _workflowTriggerRestClient.Run(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(_workflowTriggerClientDiagnostics, Pipeline, _workflowTriggerRestClient.CreateRunRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Get the trigger schema as JSON.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/schemas/json
        /// Operation Id: WorkflowTriggers_GetSchemaJson
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JsonSchema>> GetSchemaJsonAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.GetSchemaJson");
            scope.Start();
            try
            {
                var response = await _workflowTriggerRestClient.GetSchemaJsonAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the trigger schema as JSON.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/triggers/{triggerName}/schemas/json
        /// Operation Id: WorkflowTriggers_GetSchemaJson
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JsonSchema> GetSchemaJson(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowTriggerClientDiagnostics.CreateScope("WorkflowTriggerResource.GetSchemaJson");
            scope.Start();
            try
            {
                var response = _workflowTriggerRestClient.GetSchemaJson(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
