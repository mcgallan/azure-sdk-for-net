// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to update Identity Provider. </summary>
    public partial class ApiManagementIdentityProviderPatch
    {
        /// <summary> Initializes a new instance of ApiManagementIdentityProviderPatch. </summary>
        public ApiManagementIdentityProviderPatch()
        {
            AllowedTenants = new ChangeTrackingList<string>();
        }

        /// <summary> Identity Provider Type identifier. </summary>
        public IdentityProviderType? IdentityProviderType { get; set; }
        /// <summary> The TenantId to use instead of Common when logging into Active Directory. </summary>
        public string SignInTenant { get; set; }
        /// <summary> List of Allowed Tenants when configuring Azure Active Directory login. </summary>
        public IList<string> AllowedTenants { get; }
        /// <summary> OpenID Connect discovery endpoint hostname for AAD or AAD B2C. </summary>
        public string Authority { get; set; }
        /// <summary> Signup Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string SignUpPolicyName { get; set; }
        /// <summary> Signin Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string SignInPolicyName { get; set; }
        /// <summary> Profile Editing Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string ProfileEditingPolicyName { get; set; }
        /// <summary> Password Reset Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string PasswordResetPolicyName { get; set; }
        /// <summary> The client library to be used in the developer portal. Only applies to AAD and AAD B2C Identity Provider. </summary>
        public string ClientLibrary { get; set; }
        /// <summary> Client Id of the Application in the external Identity Provider. It is App ID for Facebook login, Client ID for Google login, App ID for Microsoft. </summary>
        public string ClientId { get; set; }
        /// <summary> Client secret of the Application in external Identity Provider, used to authenticate login request. For example, it is App Secret for Facebook login, API Key for Google login, Public Key for Microsoft. </summary>
        public string ClientSecret { get; set; }
    }
}
