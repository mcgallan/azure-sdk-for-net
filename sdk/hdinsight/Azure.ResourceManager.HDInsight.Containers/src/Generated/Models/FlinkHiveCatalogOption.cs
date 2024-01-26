// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Hive Catalog Option for Flink cluster. </summary>
    public partial class FlinkHiveCatalogOption
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FlinkHiveCatalogOption"/>. </summary>
        /// <param name="metastoreDBConnectionPasswordSecret"> Secret reference name from secretsProfile.secrets containing password for database connection. </param>
        /// <param name="metastoreDBConnectionUriString"> Connection string for hive metastore database. </param>
        /// <param name="metastoreDBConnectionUserName"> User name for database connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metastoreDBConnectionPasswordSecret"/>, <paramref name="metastoreDBConnectionUriString"/> or <paramref name="metastoreDBConnectionUserName"/> is null. </exception>
        public FlinkHiveCatalogOption(string metastoreDBConnectionPasswordSecret, string metastoreDBConnectionUriString, string metastoreDBConnectionUserName)
        {
            Argument.AssertNotNull(metastoreDBConnectionPasswordSecret, nameof(metastoreDBConnectionPasswordSecret));
            Argument.AssertNotNull(metastoreDBConnectionUriString, nameof(metastoreDBConnectionUriString));
            Argument.AssertNotNull(metastoreDBConnectionUserName, nameof(metastoreDBConnectionUserName));

            MetastoreDBConnectionPasswordSecret = metastoreDBConnectionPasswordSecret;
            MetastoreDBConnectionUriString = metastoreDBConnectionUriString;
            MetastoreDBConnectionUserName = metastoreDBConnectionUserName;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkHiveCatalogOption"/>. </summary>
        /// <param name="metastoreDBConnectionPasswordSecret"> Secret reference name from secretsProfile.secrets containing password for database connection. </param>
        /// <param name="metastoreDBConnectionUriString"> Connection string for hive metastore database. </param>
        /// <param name="metastoreDBConnectionUserName"> User name for database connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FlinkHiveCatalogOption(string metastoreDBConnectionPasswordSecret, string metastoreDBConnectionUriString, string metastoreDBConnectionUserName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetastoreDBConnectionPasswordSecret = metastoreDBConnectionPasswordSecret;
            MetastoreDBConnectionUriString = metastoreDBConnectionUriString;
            MetastoreDBConnectionUserName = metastoreDBConnectionUserName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkHiveCatalogOption"/> for deserialization. </summary>
        internal FlinkHiveCatalogOption()
        {
        }

        /// <summary> Secret reference name from secretsProfile.secrets containing password for database connection. </summary>
        public string MetastoreDBConnectionPasswordSecret { get; set; }
        /// <summary> Connection string for hive metastore database. </summary>
        public string MetastoreDBConnectionUriString { get; set; }
        /// <summary> User name for database connection. </summary>
        public string MetastoreDBConnectionUserName { get; set; }
    }
}
