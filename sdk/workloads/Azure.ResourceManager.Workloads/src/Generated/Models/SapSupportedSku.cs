// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SAP supported SKU. </summary>
    public partial class SapSupportedSku
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

        /// <summary> Initializes a new instance of <see cref="SapSupportedSku"/>. </summary>
        internal SapSupportedSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapSupportedSku"/>. </summary>
        /// <param name="vmSku"> The VM Sku. </param>
        /// <param name="isAppServerCertified"> True if the Sku is certified for App server in the SAP system. </param>
        /// <param name="isDatabaseCertified"> True if the Sku is certified for Database server in the SAP system. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapSupportedSku(string vmSku, bool? isAppServerCertified, bool? isDatabaseCertified, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmSku = vmSku;
            IsAppServerCertified = isAppServerCertified;
            IsDatabaseCertified = isDatabaseCertified;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The VM Sku. </summary>
        public string VmSku { get; }
        /// <summary> True if the Sku is certified for App server in the SAP system. </summary>
        public bool? IsAppServerCertified { get; }
        /// <summary> True if the Sku is certified for Database server in the SAP system. </summary>
        public bool? IsDatabaseCertified { get; }
    }
}
