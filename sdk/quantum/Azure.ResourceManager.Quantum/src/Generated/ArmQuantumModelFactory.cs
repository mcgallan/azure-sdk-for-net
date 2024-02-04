// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Quantum;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmQuantumModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Quantum.QuantumWorkspaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed Identity information. Current supported identity types: SystemAssigned, None. </param>
        /// <param name="providers"> List of Providers selected for this Workspace. </param>
        /// <param name="usable"> Whether the current workspace is ready to accept Jobs. </param>
        /// <param name="provisioningState"> Provisioning status field. </param>
        /// <param name="storageAccount"> ARM Resource Id of the storage account associated with this workspace. </param>
        /// <param name="endpointUri"> The URI of the workspace endpoint. </param>
        /// <returns> A new <see cref="Quantum.QuantumWorkspaceData"/> instance for mocking. </returns>
        public static QuantumWorkspaceData QuantumWorkspaceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, IEnumerable<Provider> providers = null, UsableStatus? usable = null, ProvisioningStatus? provisioningState = null, string storageAccount = null, Uri endpointUri = null)
        {
            tags ??= new Dictionary<string, string>();
            providers ??= new List<Provider>();

            return new QuantumWorkspaceData(id, name, resourceType, systemData, tags, location, identity, providers?.ToList(), usable, provisioningState, storageAccount, endpointUri, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ProviderDescription"/>. </summary>
        /// <param name="id"> Unique provider's id. </param>
        /// <param name="name"> Provider's display name. </param>
        /// <param name="properties"> A list of provider-specific properties. </param>
        /// <returns> A new <see cref="Models.ProviderDescription"/> instance for mocking. </returns>
        public static ProviderDescription ProviderDescription(string id = null, string name = null, ProviderProperties properties = null)
        {
            return new ProviderDescription(id, name, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ProviderProperties"/>. </summary>
        /// <param name="description"> A description about this provider. </param>
        /// <param name="providerType"> Provider type. </param>
        /// <param name="company"> Company name. </param>
        /// <param name="defaultEndpoint"> Provider's default endpoint. </param>
        /// <param name="aad"> Azure Active Directory info. </param>
        /// <param name="managedApplication"> Provider's Managed-Application info. </param>
        /// <param name="targets"> The list of targets available from this provider. </param>
        /// <param name="skus"> The list of skus available from this provider. </param>
        /// <param name="quotaDimensions"> The list of quota dimensions from the provider. </param>
        /// <param name="pricingDimensions"> The list of pricing dimensions from the provider. </param>
        /// <returns> A new <see cref="Models.ProviderProperties"/> instance for mocking. </returns>
        public static ProviderProperties ProviderProperties(string description = null, string providerType = null, string company = null, string defaultEndpoint = null, ProviderPropertiesAad aad = null, ProviderPropertiesManagedApplication managedApplication = null, IEnumerable<TargetDescription> targets = null, IEnumerable<SkuDescription> skus = null, IEnumerable<QuotaDimension> quotaDimensions = null, IEnumerable<PricingDimension> pricingDimensions = null)
        {
            targets ??= new List<TargetDescription>();
            skus ??= new List<SkuDescription>();
            quotaDimensions ??= new List<QuotaDimension>();
            pricingDimensions ??= new List<PricingDimension>();

            return new ProviderProperties(description, providerType, company, defaultEndpoint, aad, managedApplication, targets?.ToList(), skus?.ToList(), quotaDimensions?.ToList(), pricingDimensions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ProviderPropertiesAad"/>. </summary>
        /// <param name="applicationId"> Provider's application id. </param>
        /// <param name="tenantId"> Provider's tenant id. </param>
        /// <returns> A new <see cref="Models.ProviderPropertiesAad"/> instance for mocking. </returns>
        public static ProviderPropertiesAad ProviderPropertiesAad(string applicationId = null, Guid? tenantId = null)
        {
            return new ProviderPropertiesAad(applicationId, tenantId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ProviderPropertiesManagedApplication"/>. </summary>
        /// <param name="publisherId"> Provider's publisher id. </param>
        /// <param name="offerId"> Provider's offer id. </param>
        /// <returns> A new <see cref="Models.ProviderPropertiesManagedApplication"/> instance for mocking. </returns>
        public static ProviderPropertiesManagedApplication ProviderPropertiesManagedApplication(string publisherId = null, string offerId = null)
        {
            return new ProviderPropertiesManagedApplication(publisherId, offerId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.TargetDescription"/>. </summary>
        /// <param name="id"> Unique target id. </param>
        /// <param name="name"> Display name of this target. </param>
        /// <param name="description"> A description about this target. </param>
        /// <param name="acceptedDataFormats"> List of data formats accepted by this target. </param>
        /// <param name="acceptedContentEncodings"> List of content encodings accepted by this target. </param>
        /// <returns> A new <see cref="Models.TargetDescription"/> instance for mocking. </returns>
        public static TargetDescription TargetDescription(string id = null, string name = null, string description = null, IEnumerable<string> acceptedDataFormats = null, IEnumerable<string> acceptedContentEncodings = null)
        {
            acceptedDataFormats ??= new List<string>();
            acceptedContentEncodings ??= new List<string>();

            return new TargetDescription(id, name, description, acceptedDataFormats?.ToList(), acceptedContentEncodings?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SkuDescription"/>. </summary>
        /// <param name="id"> Unique sku id. </param>
        /// <param name="name"> Display name of this sku. </param>
        /// <param name="version"> Display name of this sku. </param>
        /// <param name="description"> Description about this sku. </param>
        /// <param name="restrictedAccessUri"> Uri to subscribe to the restricted access sku. </param>
        /// <param name="autoAdd"> Flag to indicate whether the sku should be automatically added during workspace creation. </param>
        /// <param name="targets"> The list of targets available for this sku. </param>
        /// <param name="quotaDimensions"> The list of quota dimensions for this sku. </param>
        /// <param name="pricingDetails"> The list of pricing details for the sku. </param>
        /// <returns> A new <see cref="Models.SkuDescription"/> instance for mocking. </returns>
        public static SkuDescription SkuDescription(string id = null, string name = null, string version = null, string description = null, Uri restrictedAccessUri = null, bool? autoAdd = null, IEnumerable<string> targets = null, IEnumerable<QuotaDimension> quotaDimensions = null, IEnumerable<PricingDetail> pricingDetails = null)
        {
            targets ??= new List<string>();
            quotaDimensions ??= new List<QuotaDimension>();
            pricingDetails ??= new List<PricingDetail>();

            return new SkuDescription(id, name, version, description, restrictedAccessUri, autoAdd, targets?.ToList(), quotaDimensions?.ToList(), pricingDetails?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaDimension"/>. </summary>
        /// <param name="id"> Unique id of this dimension. </param>
        /// <param name="scope"> The scope of this quota dimension. </param>
        /// <param name="period"> The reset period of this quota dimension. </param>
        /// <param name="quota"> The max limit of this dimension. </param>
        /// <param name="name"> The display name of this quota dimension. </param>
        /// <param name="description"> A description about this quota dimension. </param>
        /// <param name="unit"> The standard unit of measurement used for this quota dimension. </param>
        /// <param name="unitPlural"> The standard unit of measurement used for this quota dimension in plural form. </param>
        /// <returns> A new <see cref="Models.QuotaDimension"/> instance for mocking. </returns>
        public static QuotaDimension QuotaDimension(string id = null, string scope = null, string period = null, float? quota = null, string name = null, string description = null, string unit = null, string unitPlural = null)
        {
            return new QuotaDimension(id, scope, period, quota, name, description, unit, unitPlural, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PricingDetail"/>. </summary>
        /// <param name="id"> Unique id for this pricing information. </param>
        /// <param name="value"> The unit cost of this sku. </param>
        /// <returns> A new <see cref="Models.PricingDetail"/> instance for mocking. </returns>
        public static PricingDetail PricingDetail(string id = null, string value = null)
        {
            return new PricingDetail(id, value, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PricingDimension"/>. </summary>
        /// <param name="id"> Unique id of this pricing dimension. </param>
        /// <param name="name"> The display name of this pricing dimension. </param>
        /// <returns> A new <see cref="Models.PricingDimension"/> instance for mocking. </returns>
        public static PricingDimension PricingDimension(string id = null, string name = null)
        {
            return new PricingDimension(id, name, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CheckNameAvailabilityResult"/>. </summary>
        /// <param name="nameAvailable"> Indicator of availability of the Quantum Workspace resource name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The detailed info regarding the reason associated with the Namespace. </param>
        /// <returns> A new <see cref="Models.CheckNameAvailabilityResult"/> instance for mocking. </returns>
        public static CheckNameAvailabilityResult CheckNameAvailabilityResult(bool? nameAvailable = null, string reason = null, string message = null)
        {
            return new CheckNameAvailabilityResult(nameAvailable, reason, message, serializedAdditionalRawData: null);
        }
    }
}
