// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Web activity. </summary>
    public partial class WebActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="WebActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="uri"> Web activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="uri"/> is null. </exception>
        public WebActivity(string name, WebActivityMethod method, DataFactoryElement<string> uri) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(uri, nameof(uri));

            Method = method;
            Uri = uri;
            Headers = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
            Datasets = new ChangeTrackingList<DatasetReference>();
            LinkedServices = new ChangeTrackingList<DataFactoryLinkedServiceReference>();
            ActivityType = "WebActivity";
        }

        /// <summary> Initializes a new instance of <see cref="WebActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="uri"> Web activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <param name="headers"> Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string). </param>
        /// <param name="body"> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Authentication method used for calling the endpoint. </param>
        /// <param name="disableCertValidation"> When set to true, Certificate validation will be disabled. </param>
        /// <param name="httpRequestTimeout"> Timeout for the HTTP request to get a response. Format is in TimeSpan (hh:mm:ss). This value is the timeout to get a response, not the activity timeout. The default value is 00:01:00 (1 minute). The range is from 1 to 10 minutes. </param>
        /// <param name="turnOffAsync"> Option to disable invoking HTTP GET on location given in response header of a HTTP 202 Response. If set true, it stops invoking HTTP GET on http location given in response header. If set false then continues to invoke HTTP GET call on location given in http response headers. </param>
        /// <param name="datasets"> List of datasets passed to web endpoint. </param>
        /// <param name="linkedServices"> List of linked services passed to web endpoint. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        internal WebActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, WebActivityMethod method, DataFactoryElement<string> uri, IDictionary<string, DataFactoryElement<string>> headers, DataFactoryElement<string> body, WebActivityAuthentication authentication, bool? disableCertValidation, DataFactoryElement<string> httpRequestTimeout, bool? turnOffAsync, IList<DatasetReference> datasets, IList<DataFactoryLinkedServiceReference> linkedServices, IntegrationRuntimeReference connectVia) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Method = method;
            Uri = uri;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            DisableCertValidation = disableCertValidation;
            HttpRequestTimeout = httpRequestTimeout;
            TurnOffAsync = turnOffAsync;
            Datasets = datasets;
            LinkedServices = linkedServices;
            ConnectVia = connectVia;
            ActivityType = activityType ?? "WebActivity";
        }

        /// <summary> Initializes a new instance of <see cref="WebActivity"/> for deserialization. </summary>
        internal WebActivity()
        {
        }

        /// <summary> Rest API method for target endpoint. </summary>
        public WebActivityMethod Method { get; set; }
        /// <summary> Web activity target endpoint and path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string). </summary>
        public IDictionary<string, DataFactoryElement<string>> Headers { get; }
        /// <summary> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Body { get; set; }
        /// <summary> Authentication method used for calling the endpoint. </summary>
        public WebActivityAuthentication Authentication { get; set; }
        /// <summary> When set to true, Certificate validation will be disabled. </summary>
        public bool? DisableCertValidation { get; set; }
        /// <summary> Timeout for the HTTP request to get a response. Format is in TimeSpan (hh:mm:ss). This value is the timeout to get a response, not the activity timeout. The default value is 00:01:00 (1 minute). The range is from 1 to 10 minutes. </summary>
        public DataFactoryElement<string> HttpRequestTimeout { get; set; }
        /// <summary> Option to disable invoking HTTP GET on location given in response header of a HTTP 202 Response. If set true, it stops invoking HTTP GET on http location given in response header. If set false then continues to invoke HTTP GET call on location given in http response headers. </summary>
        public bool? TurnOffAsync { get; set; }
        /// <summary> List of datasets passed to web endpoint. </summary>
        public IList<DatasetReference> Datasets { get; }
        /// <summary> List of linked services passed to web endpoint. </summary>
        public IList<DataFactoryLinkedServiceReference> LinkedServices { get; }
        /// <summary> The integration runtime reference. </summary>
        public IntegrationRuntimeReference ConnectVia { get; set; }
    }
}
