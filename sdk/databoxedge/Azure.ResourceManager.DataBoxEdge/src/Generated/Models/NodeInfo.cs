// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Kubernetes node info. </summary>
    public partial class NodeInfo
    {
        /// <summary> Initializes a new instance of NodeInfo. </summary>
        internal NodeInfo()
        {
            IPConfiguration = new ChangeTrackingList<KubernetesIPConfiguration>();
        }

        /// <summary> Initializes a new instance of NodeInfo. </summary>
        /// <param name="name"> Node name. </param>
        /// <param name="kubernetesNodeType"> Node type - Master/Worker. </param>
        /// <param name="ipConfiguration"> IP Configuration of the Kubernetes node. </param>
        internal NodeInfo(string name, KubernetesNodeType? kubernetesNodeType, IReadOnlyList<KubernetesIPConfiguration> ipConfiguration)
        {
            Name = name;
            KubernetesNodeType = kubernetesNodeType;
            IPConfiguration = ipConfiguration;
        }

        /// <summary> Node name. </summary>
        public string Name { get; }
        /// <summary> Node type - Master/Worker. </summary>
        public KubernetesNodeType? KubernetesNodeType { get; }
        /// <summary> IP Configuration of the Kubernetes node. </summary>
        public IReadOnlyList<KubernetesIPConfiguration> IPConfiguration { get; }
    }
}
