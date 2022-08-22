// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The VerificationCodeResponseProperties. </summary>
    public partial class VerificationCodeResponseProperties
    {
        /// <summary> Initializes a new instance of VerificationCodeResponseProperties. </summary>
        internal VerificationCodeResponseProperties()
        {
        }

        /// <summary> Initializes a new instance of VerificationCodeResponseProperties. </summary>
        /// <param name="verificationCode"> Verification code. </param>
        /// <param name="subject"> Certificate subject. </param>
        /// <param name="expiry"> Code expiry. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="isVerified"> Indicate if the certificate is verified by owner of private key. </param>
        /// <param name="certificate"> base-64 representation of X509 certificate .cer file or just .pem file content. </param>
        /// <param name="created"> Certificate created time. </param>
        /// <param name="updated"> Certificate updated time. </param>
        internal VerificationCodeResponseProperties(string verificationCode, string subject, string expiry, string thumbprint, bool? isVerified, byte[] certificate, string created, string updated)
        {
            VerificationCode = verificationCode;
            Subject = subject;
            Expiry = expiry;
            Thumbprint = thumbprint;
            IsVerified = isVerified;
            Certificate = certificate;
            Created = created;
            Updated = updated;
        }

        /// <summary> Verification code. </summary>
        public string VerificationCode { get; }
        /// <summary> Certificate subject. </summary>
        public string Subject { get; }
        /// <summary> Code expiry. </summary>
        public string Expiry { get; }
        /// <summary> Certificate thumbprint. </summary>
        public string Thumbprint { get; }
        /// <summary> Indicate if the certificate is verified by owner of private key. </summary>
        public bool? IsVerified { get; }
        /// <summary> base-64 representation of X509 certificate .cer file or just .pem file content. </summary>
        public byte[] Certificate { get; }
        /// <summary> Certificate created time. </summary>
        public string Created { get; }
        /// <summary> Certificate updated time. </summary>
        public string Updated { get; }
    }
}
