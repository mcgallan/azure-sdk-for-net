// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Store;
using Microsoft.WindowsAzure.Management.Store.Models;

namespace Microsoft.WindowsAzure.Management.Store
{
    /// <summary>
    /// Provides REST operations for working with cloud services from the
    /// Windows Azure store service.
    /// </summary>
    internal partial class CloudServiceOperations : IServiceOperations<StoreManagementClient>, Microsoft.WindowsAzure.Management.Store.ICloudServiceOperations
    {
        /// <summary>
        /// Initializes a new instance of the CloudServiceOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal CloudServiceOperations(StoreManagementClient client)
        {
            this._client = client;
        }
        
        private StoreManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Store.StoreManagementClient.
        /// </summary>
        public StoreManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The Create Cloud Service operation creates a Windows Azure cloud
        /// service in a Windows Azure subscription.
        /// </summary>
        /// <param name='parameters'>
        /// Required. Parameters used to specify how the Create procedure will
        /// function.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async System.Threading.Tasks.Task<OperationStatusResponse> BeginCreatingAsync(CloudServiceCreateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.Description == null)
            {
                throw new ArgumentNullException("parameters.Description");
            }
            if (parameters.GeoRegion == null)
            {
                throw new ArgumentNullException("parameters.GeoRegion");
            }
            if (parameters.Label == null)
            {
                throw new ArgumentNullException("parameters.Label");
            }
            if (parameters.Name == null)
            {
                throw new ArgumentNullException("parameters.Name");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                Tracing.Enter(invocationId, this, "BeginCreatingAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/CloudServices/" + parameters.Name.Trim() + "/";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2013-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement cloudServiceElement = new XElement(XName.Get("CloudService", "http://schemas.microsoft.com/windowsazure"));
                requestDoc.Add(cloudServiceElement);
                
                XElement nameElement = new XElement(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                nameElement.Value = parameters.Name;
                cloudServiceElement.Add(nameElement);
                
                XElement labelElement = new XElement(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                labelElement.Value = parameters.Label;
                cloudServiceElement.Add(labelElement);
                
                XElement descriptionElement = new XElement(XName.Get("Description", "http://schemas.microsoft.com/windowsazure"));
                descriptionElement.Value = parameters.Description;
                cloudServiceElement.Add(descriptionElement);
                
                XElement geoRegionElement = new XElement(XName.Get("GeoRegion", "http://schemas.microsoft.com/windowsazure"));
                geoRegionElement.Value = parameters.GeoRegion;
                cloudServiceElement.Add(geoRegionElement);
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    OperationStatusResponse result = null;
                    result = new OperationStatusResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// The Create Cloud Service operation creates a Windows Azure cloud
        /// service in a Windows Azure subscription.
        /// </summary>
        /// <param name='parameters'>
        /// Required. Parameters used to specify how the Create procedure will
        /// function.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async System.Threading.Tasks.Task<OperationStatusResponse> CreateAsync(CloudServiceCreateParameters parameters, CancellationToken cancellationToken)
        {
            StoreManagementClient client = this.Client;
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                Tracing.Enter(invocationId, this, "CreateAsync", tracingParameters);
            }
            try
            {
                if (shouldTrace)
                {
                    client = this.Client.WithHandler(new ClientRequestTrackingHandler(invocationId));
                }
                
                cancellationToken.ThrowIfCancellationRequested();
                OperationStatusResponse response = await client.CloudServices.BeginCreatingAsync(parameters, cancellationToken).ConfigureAwait(false);
                if (response.Status == OperationStatus.Succeeded)
                {
                    return response;
                }
                cancellationToken.ThrowIfCancellationRequested();
                OperationStatusResponse result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                int delayInSeconds = 30;
                if (client.LongRunningOperationInitialTimeout >= 0)
                {
                    delayInSeconds = client.LongRunningOperationInitialTimeout;
                }
                while ((result.Status != OperationStatus.InProgress) == false)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    await TaskEx.Delay(delayInSeconds * 1000, cancellationToken).ConfigureAwait(false);
                    cancellationToken.ThrowIfCancellationRequested();
                    result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                    delayInSeconds = 30;
                    if (client.LongRunningOperationRetryTimeout >= 0)
                    {
                        delayInSeconds = client.LongRunningOperationRetryTimeout;
                    }
                }
                
                if (shouldTrace)
                {
                    Tracing.Exit(invocationId, result);
                }
                
                if (result.Status != OperationStatus.Succeeded)
                {
                    if (result.Error != null)
                    {
                        CloudException ex = new CloudException(result.Error.Code + " : " + result.Error.Message);
                        ex.ErrorCode = result.Error.Code;
                        ex.ErrorMessage = result.Error.Message;
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    else
                    {
                        CloudException ex = new CloudException("");
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                }
                
                return result;
            }
            finally
            {
                if (client != null && shouldTrace)
                {
                    client.Dispose();
                }
            }
        }
        
        /// <summary>
        /// The List Cloud Services operation enumerates Windows Azure Store
        /// entries that are provisioned for a subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the Cloud Service List operation.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Store.Models.CloudServiceListResponse> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/CloudServices/";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2013-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    CloudServiceListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new CloudServiceListResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement cloudServicesSequenceElement = responseDoc.Element(XName.Get("CloudServices", "http://schemas.microsoft.com/windowsazure"));
                    if (cloudServicesSequenceElement != null)
                    {
                        result.CloudServices = new List<CloudServiceListResponse.CloudService>();
                        foreach (XElement cloudServicesElement in cloudServicesSequenceElement.Elements(XName.Get("CloudService", "http://schemas.microsoft.com/windowsazure")))
                        {
                            CloudServiceListResponse.CloudService cloudServiceInstance = new CloudServiceListResponse.CloudService();
                            result.CloudServices.Add(cloudServiceInstance);
                            
                            XElement nameElement = cloudServicesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                            if (nameElement != null)
                            {
                                string nameInstance = nameElement.Value;
                                cloudServiceInstance.Name = nameInstance;
                            }
                            
                            XElement labelElement = cloudServicesElement.Element(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                            if (labelElement != null)
                            {
                                string labelInstance = TypeConversion.FromBase64String(labelElement.Value);
                                cloudServiceInstance.Label = labelInstance;
                            }
                            
                            XElement descriptionElement = cloudServicesElement.Element(XName.Get("Description", "http://schemas.microsoft.com/windowsazure"));
                            if (descriptionElement != null)
                            {
                                string descriptionInstance = descriptionElement.Value;
                                cloudServiceInstance.Description = descriptionInstance;
                            }
                            
                            XElement geoRegionElement = cloudServicesElement.Element(XName.Get("GeoRegion", "http://schemas.microsoft.com/windowsazure"));
                            if (geoRegionElement != null)
                            {
                                string geoRegionInstance = geoRegionElement.Value;
                                cloudServiceInstance.GeoRegion = geoRegionInstance;
                            }
                            
                            XElement resourcesSequenceElement = cloudServicesElement.Element(XName.Get("Resources", "http://schemas.microsoft.com/windowsazure"));
                            if (resourcesSequenceElement != null)
                            {
                                cloudServiceInstance.Resources = new List<CloudServiceListResponse.CloudService.AddOnResource>();
                                foreach (XElement resourcesElement in resourcesSequenceElement.Elements(XName.Get("Resource", "http://schemas.microsoft.com/windowsazure")))
                                {
                                    CloudServiceListResponse.CloudService.AddOnResource resourceInstance = new CloudServiceListResponse.CloudService.AddOnResource();
                                    cloudServiceInstance.Resources.Add(resourceInstance);
                                    
                                    XElement resourceProviderNamespaceElement = resourcesElement.Element(XName.Get("ResourceProviderNamespace", "http://schemas.microsoft.com/windowsazure"));
                                    if (resourceProviderNamespaceElement != null)
                                    {
                                        string resourceProviderNamespaceInstance = resourceProviderNamespaceElement.Value;
                                        resourceInstance.Namespace = resourceProviderNamespaceInstance;
                                    }
                                    
                                    XElement typeElement = resourcesElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                    if (typeElement != null)
                                    {
                                        string typeInstance = typeElement.Value;
                                        resourceInstance.Type = typeInstance;
                                    }
                                    
                                    XElement nameElement2 = resourcesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                    if (nameElement2 != null)
                                    {
                                        string nameInstance2 = nameElement2.Value;
                                        resourceInstance.Name = nameInstance2;
                                    }
                                    
                                    XElement planElement = resourcesElement.Element(XName.Get("Plan", "http://schemas.microsoft.com/windowsazure"));
                                    if (planElement != null)
                                    {
                                        string planInstance = planElement.Value;
                                        resourceInstance.Plan = planInstance;
                                    }
                                    
                                    XElement schemaVersionElement = resourcesElement.Element(XName.Get("SchemaVersion", "http://schemas.microsoft.com/windowsazure"));
                                    if (schemaVersionElement != null)
                                    {
                                        string schemaVersionInstance = schemaVersionElement.Value;
                                        resourceInstance.SchemaVersion = schemaVersionInstance;
                                    }
                                    
                                    XElement eTagElement = resourcesElement.Element(XName.Get("ETag", "http://schemas.microsoft.com/windowsazure"));
                                    if (eTagElement != null)
                                    {
                                        string eTagInstance = eTagElement.Value;
                                        resourceInstance.ETag = eTagInstance;
                                    }
                                    
                                    XElement stateElement = resourcesElement.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                                    if (stateElement != null)
                                    {
                                        string stateInstance = stateElement.Value;
                                        resourceInstance.State = stateInstance;
                                    }
                                    
                                    XElement usageMetersSequenceElement = resourcesElement.Element(XName.Get("UsageMeters", "http://schemas.microsoft.com/windowsazure"));
                                    if (usageMetersSequenceElement != null)
                                    {
                                        resourceInstance.UsageLimits = new List<CloudServiceListResponse.CloudService.AddOnResource.UsageLimit>();
                                        foreach (XElement usageMetersElement in usageMetersSequenceElement.Elements(XName.Get("UsageMeter", "http://schemas.microsoft.com/windowsazure")))
                                        {
                                            CloudServiceListResponse.CloudService.AddOnResource.UsageLimit usageMeterInstance = new CloudServiceListResponse.CloudService.AddOnResource.UsageLimit();
                                            resourceInstance.UsageLimits.Add(usageMeterInstance);
                                            
                                            XElement nameElement3 = usageMetersElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                            if (nameElement3 != null)
                                            {
                                                string nameInstance3 = nameElement3.Value;
                                                usageMeterInstance.Name = nameInstance3;
                                            }
                                            
                                            XElement unitElement = usageMetersElement.Element(XName.Get("Unit", "http://schemas.microsoft.com/windowsazure"));
                                            if (unitElement != null)
                                            {
                                                string unitInstance = unitElement.Value;
                                                usageMeterInstance.Unit = unitInstance;
                                            }
                                            
                                            XElement includedElement = usageMetersElement.Element(XName.Get("Included", "http://schemas.microsoft.com/windowsazure"));
                                            if (includedElement != null)
                                            {
                                                long includedInstance = long.Parse(includedElement.Value, CultureInfo.InvariantCulture);
                                                usageMeterInstance.AmountIncluded = includedInstance;
                                            }
                                            
                                            XElement usedElement = usageMetersElement.Element(XName.Get("Used", "http://schemas.microsoft.com/windowsazure"));
                                            if (usedElement != null)
                                            {
                                                long usedInstance = long.Parse(usedElement.Value, CultureInfo.InvariantCulture);
                                                usageMeterInstance.AmountUsed = usedInstance;
                                            }
                                        }
                                    }
                                    
                                    XElement outputItemsSequenceElement = resourcesElement.Element(XName.Get("OutputItems", "http://schemas.microsoft.com/windowsazure"));
                                    if (outputItemsSequenceElement != null)
                                    {
                                        resourceInstance.OutputItems = new Dictionary<string, string>();
                                        foreach (XElement outputItemsElement in outputItemsSequenceElement.Elements(XName.Get("OutputItem", "http://schemas.microsoft.com/windowsazure")))
                                        {
                                            string outputItemsKey = outputItemsElement.Element(XName.Get("Key", "http://schemas.microsoft.com/windowsazure")).Value;
                                            string outputItemsValue = outputItemsElement.Element(XName.Get("Value", "http://schemas.microsoft.com/windowsazure")).Value;
                                            resourceInstance.OutputItems.Add(outputItemsKey, outputItemsValue);
                                        }
                                    }
                                    
                                    XElement operationStatusElement = resourcesElement.Element(XName.Get("OperationStatus", "http://schemas.microsoft.com/windowsazure"));
                                    if (operationStatusElement != null)
                                    {
                                        CloudServiceListResponse.CloudService.AddOnResource.OperationStatus operationStatusInstance = new CloudServiceListResponse.CloudService.AddOnResource.OperationStatus();
                                        resourceInstance.Status = operationStatusInstance;
                                        
                                        XElement typeElement2 = operationStatusElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                        if (typeElement2 != null)
                                        {
                                            string typeInstance2 = typeElement2.Value;
                                            operationStatusInstance.Type = typeInstance2;
                                        }
                                        
                                        XElement resultElement = operationStatusElement.Element(XName.Get("Result", "http://schemas.microsoft.com/windowsazure"));
                                        if (resultElement != null)
                                        {
                                            string resultInstance = resultElement.Value;
                                            operationStatusInstance.Result = resultInstance;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
