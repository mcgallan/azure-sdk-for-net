// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the properties of a License Profile ARM model. </summary>
    public partial class LicenseProfileArmEsuPropertiesWithoutAssignedLicense : LicenseProfileStorageModelEsuProperties
    {
        /// <summary> Initializes a new instance of <see cref="LicenseProfileArmEsuPropertiesWithoutAssignedLicense"/>. </summary>
        public LicenseProfileArmEsuPropertiesWithoutAssignedLicense()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LicenseProfileArmEsuPropertiesWithoutAssignedLicense"/>. </summary>
        /// <param name="assignedLicenseImmutableId"> The guid id of the license. </param>
        /// <param name="esuKeys"> The list of ESU keys. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="serverType"> The type of the Esu servers. </param>
        /// <param name="esuEligibility"> Indicates the eligibility state of Esu. </param>
        /// <param name="esuKeyState"> Indicates whether there is an ESU Key currently active for the machine. </param>
        internal LicenseProfileArmEsuPropertiesWithoutAssignedLicense(Guid? assignedLicenseImmutableId, IReadOnlyList<EsuKey> esuKeys, IDictionary<string, BinaryData> serializedAdditionalRawData, EsuServerType? serverType, EsuEligibility? esuEligibility, EsuKeyState? esuKeyState) : base(assignedLicenseImmutableId, esuKeys, serializedAdditionalRawData)
        {
            ServerType = serverType;
            EsuEligibility = esuEligibility;
            EsuKeyState = esuKeyState;
        }

        /// <summary> The type of the Esu servers. </summary>
        public EsuServerType? ServerType { get; }
        /// <summary> Indicates the eligibility state of Esu. </summary>
        public EsuEligibility? EsuEligibility { get; }
        /// <summary> Indicates whether there is an ESU Key currently active for the machine. </summary>
        public EsuKeyState? EsuKeyState { get; }
    }
}
