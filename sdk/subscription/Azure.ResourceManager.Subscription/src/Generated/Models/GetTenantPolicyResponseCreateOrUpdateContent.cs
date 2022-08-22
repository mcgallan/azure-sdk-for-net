// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> Put tenant policy request properties. </summary>
    public partial class GetTenantPolicyResponseCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of GetTenantPolicyResponseCreateOrUpdateContent. </summary>
        public GetTenantPolicyResponseCreateOrUpdateContent()
        {
            ExemptedPrincipals = new ChangeTrackingList<Guid>();
        }

        /// <summary> Blocks the leaving of subscriptions from user&apos;s tenant. </summary>
        public bool? BlockSubscriptionsLeavingTenant { get; set; }
        /// <summary> Blocks the entering of subscriptions into user&apos;s tenant. </summary>
        public bool? BlockSubscriptionsIntoTenant { get; set; }
        /// <summary> List of user objectIds that are exempted from the set subscription tenant policies for the user&apos;s tenant. </summary>
        public IList<Guid> ExemptedPrincipals { get; }
    }
}
