// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The response of the get policy fragments operation. </summary>
    internal partial class PolicyFragmentListResult
    {
        /// <summary> Initializes a new instance of PolicyFragmentListResult. </summary>
        internal PolicyFragmentListResult()
        {
            Value = new ChangeTrackingList<PolicyFragmentContractData>();
        }

        /// <summary> Initializes a new instance of PolicyFragmentListResult. </summary>
        /// <param name="value"> Policy fragment contract value. </param>
        /// <param name="count"> Total record count number. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal PolicyFragmentListResult(IReadOnlyList<PolicyFragmentContractData> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> Policy fragment contract value. </summary>
        public IReadOnlyList<PolicyFragmentContractData> Value { get; }
        /// <summary> Total record count number. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
