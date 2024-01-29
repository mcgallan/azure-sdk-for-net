// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing the SphereImage data model.
    /// An image resource belonging to a catalog resource.
    /// </summary>
    public partial class SphereImageData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SphereImageData"/>. </summary>
        public SphereImageData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="image"> Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads. </param>
        /// <param name="imageId"> Image ID. </param>
        /// <param name="imageName"> Image name. </param>
        /// <param name="regionalDataBoundary"> Regional data boundary for an image. </param>
        /// <param name="uri"> Location the image. </param>
        /// <param name="description"> The image description. </param>
        /// <param name="componentId"> The image component id. </param>
        /// <param name="imageType"> The image type. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SphereImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string image, string imageId, string imageName, RegionalDataBoundary? regionalDataBoundary, Uri uri, string description, string componentId, SphereImageType? imageType, SphereProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Image = image;
            ImageId = imageId;
            ImageName = imageName;
            RegionalDataBoundary = regionalDataBoundary;
            Uri = uri;
            Description = description;
            ComponentId = componentId;
            ImageType = imageType;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads. </summary>
        public string Image { get; set; }
        /// <summary> Image ID. </summary>
        public string ImageId { get; set; }
        /// <summary> Image name. </summary>
        public string ImageName { get; }
        /// <summary> Regional data boundary for an image. </summary>
        public RegionalDataBoundary? RegionalDataBoundary { get; set; }
        /// <summary> Location the image. </summary>
        public Uri Uri { get; }
        /// <summary> The image description. </summary>
        public string Description { get; }
        /// <summary> The image component id. </summary>
        public string ComponentId { get; }
        /// <summary> The image type. </summary>
        public SphereImageType? ImageType { get; }
        /// <summary> The status of the last operation. </summary>
        public SphereProvisioningState? ProvisioningState { get; }
    }
}
