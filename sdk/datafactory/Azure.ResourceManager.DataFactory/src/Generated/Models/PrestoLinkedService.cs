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
    /// <summary> Presto server linked service. </summary>
    public partial class PrestoLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="PrestoLinkedService"/>. </summary>
        /// <param name="host"> The IP address or host name of the Presto server. (i.e. 192.168.222.160). </param>
        /// <param name="serverVersion"> The version of the Presto server. (i.e. 0.148-t). </param>
        /// <param name="catalog"> The catalog context for all request against the server. </param>
        /// <param name="authenticationType"> The authentication mechanism used to connect to the Presto server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/>, <paramref name="serverVersion"/> or <paramref name="catalog"/> is null. </exception>
        public PrestoLinkedService(DataFactoryElement<string> host, DataFactoryElement<string> serverVersion, DataFactoryElement<string> catalog, PrestoAuthenticationType authenticationType)
        {
            Argument.AssertNotNull(host, nameof(host));
            Argument.AssertNotNull(serverVersion, nameof(serverVersion));
            Argument.AssertNotNull(catalog, nameof(catalog));

            Host = host;
            ServerVersion = serverVersion;
            Catalog = catalog;
            AuthenticationType = authenticationType;
            LinkedServiceType = "Presto";
        }

        /// <summary> Initializes a new instance of <see cref="PrestoLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The IP address or host name of the Presto server. (i.e. 192.168.222.160). </param>
        /// <param name="serverVersion"> The version of the Presto server. (i.e. 0.148-t). </param>
        /// <param name="catalog"> The catalog context for all request against the server. </param>
        /// <param name="port"> The TCP port that the Presto server uses to listen for client connections. The default value is 8080. </param>
        /// <param name="authenticationType"> The authentication mechanism used to connect to the Presto server. </param>
        /// <param name="username"> The user name used to connect to the Presto server. </param>
        /// <param name="password"> The password corresponding to the user name. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </param>
        /// <param name="allowHostNameCNMismatch"> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. </param>
        /// <param name="timeZoneId"> The local time zone used by the connection. Valid values for this option are specified in the IANA Time Zone Database. The default value is the system time zone. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal PrestoLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> host, DataFactoryElement<string> serverVersion, DataFactoryElement<string> catalog, DataFactoryElement<int> port, PrestoAuthenticationType authenticationType, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password, DataFactoryElement<bool> enableSsl, DataFactoryElement<string> trustedCertPath, DataFactoryElement<bool> useSystemTrustStore, DataFactoryElement<bool> allowHostNameCNMismatch, DataFactoryElement<bool> allowSelfSignedServerCert, DataFactoryElement<string> timeZoneId, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            ServerVersion = serverVersion;
            Catalog = catalog;
            Port = port;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EnableSsl = enableSsl;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            TimeZoneId = timeZoneId;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Presto";
        }

        /// <summary> Initializes a new instance of <see cref="PrestoLinkedService"/> for deserialization. </summary>
        internal PrestoLinkedService()
        {
        }

        /// <summary> The IP address or host name of the Presto server. (i.e. 192.168.222.160). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> The version of the Presto server. (i.e. 0.148-t). </summary>
        public DataFactoryElement<string> ServerVersion { get; set; }
        /// <summary> The catalog context for all request against the server. </summary>
        public DataFactoryElement<string> Catalog { get; set; }
        /// <summary> The TCP port that the Presto server uses to listen for client connections. The default value is 8080. </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> The authentication mechanism used to connect to the Presto server. </summary>
        public PrestoAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used to connect to the Presto server. </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> The password corresponding to the user name. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </summary>
        public DataFactoryElement<bool> EnableSsl { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public DataFactoryElement<string> TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </summary>
        public DataFactoryElement<bool> UseSystemTrustStore { get; set; }
        /// <summary> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </summary>
        public DataFactoryElement<bool> AllowHostNameCNMismatch { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. </summary>
        public DataFactoryElement<bool> AllowSelfSignedServerCert { get; set; }
        /// <summary> The local time zone used by the connection. Valid values for this option are specified in the IANA Time Zone Database. The default value is the system time zone. </summary>
        public DataFactoryElement<string> TimeZoneId { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
