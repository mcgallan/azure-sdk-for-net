// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningAllFeatures. </summary>
    public partial class MachineLearningAllFeatures : MonitoringFeatureFilterBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningAllFeatures"/>. </summary>
        public MachineLearningAllFeatures()
        {
            FilterType = MonitoringFeatureFilterType.AllFeatures;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAllFeatures"/>. </summary>
        /// <param name="filterType"> [Required] Specifies the feature filter to leverage when selecting features to calculate metrics over. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningAllFeatures(MonitoringFeatureFilterType filterType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(filterType, serializedAdditionalRawData)
        {
            FilterType = filterType;
        }
    }
}
