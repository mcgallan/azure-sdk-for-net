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
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    /// <summary>
    /// A response to a request for a list of authorization rules.
    /// </summary>
    public partial class ServiceBusAuthorizationRulesResponse : OperationResponse, IEnumerable<ServiceBusSharedAccessAuthorizationRule>
    {
        private IList<ServiceBusSharedAccessAuthorizationRule> _authorizationRules;
        
        /// <summary>
        /// Optional. The list of authorization rules.
        /// </summary>
        public IList<ServiceBusSharedAccessAuthorizationRule> AuthorizationRules
        {
            get
            {
                if (this._authorizationRules == null)
                {
                    this._authorizationRules = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.ServiceBus.Models.ServiceBusSharedAccessAuthorizationRule>();
                }
                return this._authorizationRules;
            }
            set { this._authorizationRules = value; }
        }
        
        /// <summary>
        /// Optional. The list of authorization rules.
        /// </summary>
        public IList<ServiceBusSharedAccessAuthorizationRule> AuthorizationRulesValue
        {
            get { return this._authorizationRules; }
            set { this._authorizationRules = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusAuthorizationRulesResponse class.
        /// </summary>
        public ServiceBusAuthorizationRulesResponse()
        {
        }
        
        /// <summary>
        /// Gets the sequence of AuthorizationRules.
        /// </summary>
        public IEnumerator<ServiceBusSharedAccessAuthorizationRule> GetEnumerator()
        {
            return this.AuthorizationRulesValue.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of AuthorizationRules.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
