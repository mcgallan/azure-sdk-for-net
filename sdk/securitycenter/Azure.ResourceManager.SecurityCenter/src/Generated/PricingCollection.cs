// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="PricingResource" /> and their operations.
    /// Each <see cref="PricingResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="PricingCollection" /> instance call the GetPricings method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class PricingCollection : ArmCollection, IEnumerable<PricingResource>, IAsyncEnumerable<PricingResource>
    {
        private readonly ClientDiagnostics _pricingClientDiagnostics;
        private readonly PricingsRestOperations _pricingRestClient;

        /// <summary> Initializes a new instance of the <see cref="PricingCollection"/> class for mocking. </summary>
        protected PricingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PricingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PricingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _pricingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", PricingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PricingResource.ResourceType, out string pricingApiVersion);
            _pricingRestClient = new PricingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, pricingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}
        /// Operation Id: Pricings_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="data"> Pricing object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PricingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string pricingName, PricingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _pricingRestClient.UpdateAsync(Id.SubscriptionId, pricingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<PricingResource>(Response.FromValue(new PricingResource(Client, response), response.GetRawResponse()));
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
        /// Updates a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}
        /// Operation Id: Pricings_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="data"> Pricing object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PricingResource> CreateOrUpdate(WaitUntil waitUntil, string pricingName, PricingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _pricingRestClient.Update(Id.SubscriptionId, pricingName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<PricingResource>(Response.FromValue(new PricingResource(Client, response), response.GetRawResponse()));
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
        /// Gets a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}
        /// Operation Id: Pricings_Get
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual async Task<Response<PricingResource>> GetAsync(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.Get");
            scope.Start();
            try
            {
                var response = await _pricingRestClient.GetAsync(Id.SubscriptionId, pricingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}
        /// Operation Id: Pricings_Get
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual Response<PricingResource> Get(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.Get");
            scope.Start();
            try
            {
                var response = _pricingRestClient.Get(Id.SubscriptionId, pricingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Microsoft Defender for Cloud pricing configurations in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings
        /// Operation Id: Pricings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PricingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PricingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PricingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _pricingRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PricingResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists Microsoft Defender for Cloud pricing configurations in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings
        /// Operation Id: Pricings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PricingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PricingResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PricingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _pricingRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PricingResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}
        /// Operation Id: Pricings_Get
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _pricingRestClient.GetAsync(Id.SubscriptionId, pricingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}
        /// Operation Id: Pricings_Get
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual Response<bool> Exists(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _pricingClientDiagnostics.CreateScope("PricingCollection.Exists");
            scope.Start();
            try
            {
                var response = _pricingRestClient.Get(Id.SubscriptionId, pricingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PricingResource> IEnumerable<PricingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PricingResource> IAsyncEnumerable<PricingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
