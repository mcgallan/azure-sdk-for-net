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
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// The response for the List Client Root Certificates operation.
    /// </summary>
    public partial class ClientRootCertificateListResponse : OperationResponse, IEnumerable<ClientRootCertificateListResponse.ClientRootCertificate>
    {
        private IList<ClientRootCertificateListResponse.ClientRootCertificate> _clientRootCertificates;
        
        /// <summary>
        /// Optional. The list of client root certificates.
        /// </summary>
        public IList<ClientRootCertificateListResponse.ClientRootCertificate> ClientRootCertificates
        {
            get
            {
                if (this._clientRootCertificates == null)
                {
                    this._clientRootCertificates = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.Network.Models.ClientRootCertificateListResponse.ClientRootCertificate>();
                }
                return this._clientRootCertificates;
            }
            set { this._clientRootCertificates = value; }
        }
        
        /// <summary>
        /// Optional. The list of client root certificates.
        /// </summary>
        public IList<ClientRootCertificateListResponse.ClientRootCertificate> ClientRootCertificatesValue
        {
            get { return this._clientRootCertificates; }
            set { this._clientRootCertificates = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ClientRootCertificateListResponse
        /// class.
        /// </summary>
        public ClientRootCertificateListResponse()
        {
        }
        
        /// <summary>
        /// Gets the sequence of ClientRootCertificates.
        /// </summary>
        public IEnumerator<ClientRootCertificateListResponse.ClientRootCertificate> GetEnumerator()
        {
            return this.ClientRootCertificatesValue.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ClientRootCertificates.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        public partial class ClientRootCertificate
        {
            private DateTime _expirationTime;
            
            /// <summary>
            /// Optional. Specifies the time that the certificate will expire.
            /// </summary>
            public DateTime ExpirationTime
            {
                get { return this._expirationTime; }
                set { this._expirationTime = value; }
            }
            
            private string _subject;
            
            /// <summary>
            /// Optional. Specifies the distinguished name of the certificate
            /// issuer.
            /// </summary>
            public string Subject
            {
                get { return this._subject; }
                set { this._subject = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. Specifies the thumbprint of the certificate.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ClientRootCertificate class.
            /// </summary>
            public ClientRootCertificate()
            {
            }
        }
    }
}
