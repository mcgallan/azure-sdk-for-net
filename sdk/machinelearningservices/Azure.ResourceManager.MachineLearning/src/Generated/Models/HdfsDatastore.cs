// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The HdfsDatastore. </summary>
    public partial class HdfsDatastore : MachineLearningDatastoreProperties
    {
        /// <summary> Initializes a new instance of <see cref="HdfsDatastore"/>. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="nameNodeAddress"> [Required] IP Address or DNS HostName. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> or <paramref name="nameNodeAddress"/> is null. </exception>
        public HdfsDatastore(MachineLearningDatastoreCredentials credentials, string nameNodeAddress) : base(credentials)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));
            Argument.AssertNotNull(nameNodeAddress, nameof(nameNodeAddress));

            NameNodeAddress = nameNodeAddress;
            DatastoreType = DatastoreType.Hdfs;
        }

        /// <summary> Initializes a new instance of <see cref="HdfsDatastore"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="intellectualProperty"> Intellectual Property details. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="hdfsServerCertificate"> The TLS cert of the HDFS server. Needs to be a base64 encoded string. Required if "Https" protocol is selected. </param>
        /// <param name="nameNodeAddress"> [Required] IP Address or DNS HostName. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account (Https/Http). </param>
        internal HdfsDatastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningDatastoreCredentials credentials, DatastoreType datastoreType, IntellectualProperty intellectualProperty, bool? isDefault, string hdfsServerCertificate, string nameNodeAddress, string protocol) : base(description, properties, tags, serializedAdditionalRawData, credentials, datastoreType, intellectualProperty, isDefault)
        {
            HdfsServerCertificate = hdfsServerCertificate;
            NameNodeAddress = nameNodeAddress;
            Protocol = protocol;
            DatastoreType = datastoreType;
        }

        /// <summary> Initializes a new instance of <see cref="HdfsDatastore"/> for deserialization. </summary>
        internal HdfsDatastore()
        {
        }

        /// <summary> The TLS cert of the HDFS server. Needs to be a base64 encoded string. Required if "Https" protocol is selected. </summary>
        public string HdfsServerCertificate { get; set; }
        /// <summary> [Required] IP Address or DNS HostName. </summary>
        public string NameNodeAddress { get; set; }
        /// <summary> Protocol used to communicate with the storage account (Https/Http). </summary>
        public string Protocol { get; set; }
    }
}
