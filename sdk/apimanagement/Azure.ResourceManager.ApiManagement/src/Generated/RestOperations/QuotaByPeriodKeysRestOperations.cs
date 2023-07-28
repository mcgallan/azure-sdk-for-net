// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    internal partial class QuotaByPeriodKeysRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of QuotaByPeriodKeysRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public QuotaByPeriodKeysRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ApiManagement/service/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/quotas/", false);
            uri.AppendPath(quotaCounterKey, true);
            uri.AppendPath("/periods/", false);
            uri.AppendPath(quotaPeriodKey, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the value of the quota counter associated with the counter-key in the policy for the specific period in service instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="quotaCounterKey"> Quota counter key identifier.This is the result of expression defined in counter-key attribute of the quota-by-key policy.For Example, if you specify counter-key="boo" in the policy, then it’s accessible by "boo" counter key. But if it’s defined as counter-key="@("b"+"a")" then it will be accessible by "ba" key. </param>
        /// <param name="quotaPeriodKey"> Quota period key identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/> or <paramref name="quotaPeriodKey"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/> or <paramref name="quotaPeriodKey"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QuotaCounterContract>> GetAsync(string subscriptionId, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(quotaCounterKey, nameof(quotaCounterKey));
            Argument.AssertNotNullOrEmpty(quotaPeriodKey, nameof(quotaPeriodKey));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaCounterContract value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaCounterContract.DeserializeQuotaCounterContract(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the value of the quota counter associated with the counter-key in the policy for the specific period in service instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="quotaCounterKey"> Quota counter key identifier.This is the result of expression defined in counter-key attribute of the quota-by-key policy.For Example, if you specify counter-key="boo" in the policy, then it’s accessible by "boo" counter key. But if it’s defined as counter-key="@("b"+"a")" then it will be accessible by "ba" key. </param>
        /// <param name="quotaPeriodKey"> Quota period key identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/> or <paramref name="quotaPeriodKey"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/> or <paramref name="quotaPeriodKey"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QuotaCounterContract> Get(string subscriptionId, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(quotaCounterKey, nameof(quotaCounterKey));
            Argument.AssertNotNullOrEmpty(quotaPeriodKey, nameof(quotaPeriodKey));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaCounterContract value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaCounterContract.DeserializeQuotaCounterContract(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, QuotaCounterValueUpdateContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ApiManagement/service/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/quotas/", false);
            uri.AppendPath(quotaCounterKey, true);
            uri.AppendPath("/periods/", false);
            uri.AppendPath(quotaPeriodKey, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates an existing quota counter value in the specified service instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="quotaCounterKey"> Quota counter key identifier.This is the result of expression defined in counter-key attribute of the quota-by-key policy.For Example, if you specify counter-key="boo" in the policy, then it’s accessible by "boo" counter key. But if it’s defined as counter-key="@("b"+"a")" then it will be accessible by "ba" key. </param>
        /// <param name="quotaPeriodKey"> Quota period key identifier. </param>
        /// <param name="content"> The value of the Quota counter to be applied on the specified period. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/>, <paramref name="quotaPeriodKey"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/> or <paramref name="quotaPeriodKey"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QuotaCounterContract>> UpdateAsync(string subscriptionId, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, QuotaCounterValueUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(quotaCounterKey, nameof(quotaCounterKey));
            Argument.AssertNotNullOrEmpty(quotaPeriodKey, nameof(quotaPeriodKey));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaCounterContract value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaCounterContract.DeserializeQuotaCounterContract(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates an existing quota counter value in the specified service instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="quotaCounterKey"> Quota counter key identifier.This is the result of expression defined in counter-key attribute of the quota-by-key policy.For Example, if you specify counter-key="boo" in the policy, then it’s accessible by "boo" counter key. But if it’s defined as counter-key="@("b"+"a")" then it will be accessible by "ba" key. </param>
        /// <param name="quotaPeriodKey"> Quota period key identifier. </param>
        /// <param name="content"> The value of the Quota counter to be applied on the specified period. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/>, <paramref name="quotaPeriodKey"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="quotaCounterKey"/> or <paramref name="quotaPeriodKey"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QuotaCounterContract> Update(string subscriptionId, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, QuotaCounterValueUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(quotaCounterKey, nameof(quotaCounterKey));
            Argument.AssertNotNullOrEmpty(quotaPeriodKey, nameof(quotaPeriodKey));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaCounterContract value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaCounterContract.DeserializeQuotaCounterContract(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
