// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A representation of a single generated image, provided as either base64-encoded data or as a URL from which the image
    /// may be retrieved.
    /// </summary>
    public partial class ImageGenerationData
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

        /// <summary> Initializes a new instance of <see cref="ImageGenerationData"/>. </summary>
        internal ImageGenerationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageGenerationData"/>. </summary>
        /// <param name="url"> The URL that provides temporary access to download the generated image. </param>
        /// <param name="base64Data"> The complete data for an image, represented as a base64-encoded string. </param>
        /// <param name="revisedPrompt">
        /// The final prompt used by the model to generate the image.
        /// Only provided with dall-3-models and only when revisions were made to the prompt.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageGenerationData(Uri url, string base64Data, string revisedPrompt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Url = url;
            Base64Data = base64Data;
            RevisedPrompt = revisedPrompt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URL that provides temporary access to download the generated image. </summary>
        public Uri Url { get; }
        /// <summary> The complete data for an image, represented as a base64-encoded string. </summary>
        public string Base64Data { get; }
        /// <summary>
        /// The final prompt used by the model to generate the image.
        /// Only provided with dall-3-models and only when revisions were made to the prompt.
        /// </summary>
        public string RevisedPrompt { get; }
    }
}
