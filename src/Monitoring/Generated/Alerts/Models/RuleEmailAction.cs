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
using Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models;

namespace Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models
{
    /// <summary>
    /// Specifies the action to send email when the rule condition is evaluated.
    /// </summary>
    public partial class RuleEmailAction : RuleAction
    {
        private IList<string> _customEmails;
        
        /// <summary>
        /// Optional. The email address of an adminstrative user.
        /// </summary>
        public IList<string> CustomEmails
        {
            get
            {
                if (this._customEmails == null)
                {
                    this._customEmails = new System.Collections.Generic.List<string>();
                }
                return this._customEmails;
            }
            set { this._customEmails = value; }
        }
        
        /// <summary>
        /// Optional. The email address of an adminstrative user.
        /// </summary>
        public IList<string> CustomEmailsValue
        {
            get { return this._customEmails; }
            set { this._customEmails = value; }
        }
        
        private bool _sendToServiceOwners;
        
        /// <summary>
        /// Optional. This indicates if email is sent to sevice adminstrator
        /// and co-administrators.
        /// </summary>
        public bool SendToServiceOwners
        {
            get { return this._sendToServiceOwners; }
            set { this._sendToServiceOwners = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RuleEmailAction class.
        /// </summary>
        public RuleEmailAction()
        {
        }
    }
}
