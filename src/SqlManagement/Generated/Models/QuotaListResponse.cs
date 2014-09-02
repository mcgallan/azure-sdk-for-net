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
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Represents the response structure for the Quota List operation.
    /// </summary>
    public partial class QuotaListResponse : OperationResponse, IEnumerable<Quota>
    {
        private IList<Quota> _quotas;
        
        /// <summary>
        /// Optional. Gets or sets the collection of all the Quotas for the
        /// server.
        /// </summary>
        public IList<Quota> Quotas
        {
            get
            {
                if (this._quotas == null)
                {
                    this._quotas = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.Sql.Models.Quota>();
                }
                return this._quotas;
            }
            set { this._quotas = value; }
        }
        
        /// <summary>
        /// Optional. Gets or sets the collection of all the Quotas for the
        /// server.
        /// </summary>
        public IList<Quota> QuotasValue
        {
            get { return this._quotas; }
            set { this._quotas = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the QuotaListResponse class.
        /// </summary>
        public QuotaListResponse()
        {
        }
        
        /// <summary>
        /// Gets the sequence of Quotas.
        /// </summary>
        public IEnumerator<Quota> GetEnumerator()
        {
            return this.QuotasValue.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Quotas.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
