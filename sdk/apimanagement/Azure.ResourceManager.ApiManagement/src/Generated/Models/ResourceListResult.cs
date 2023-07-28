// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> A collection of resources. </summary>
    internal partial class ResourceListResult
    {
        /// <summary> Initializes a new instance of ResourceListResult. </summary>
        internal ResourceListResult()
        {
            Value = new ChangeTrackingList<ResourceCollectionValueItem>();
        }

        /// <summary> Initializes a new instance of ResourceListResult. </summary>
        /// <param name="value"> A collection of resources. </param>
        /// <param name="count"> Total record count number. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal ResourceListResult(IReadOnlyList<ResourceCollectionValueItem> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> A collection of resources. </summary>
        public IReadOnlyList<ResourceCollectionValueItem> Value { get; }
        /// <summary> Total record count number. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
