// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes a raw input data source that contains reference data. This data source type is only applicable/usable when using the query testing API. You cannot create a job with this data source type or add an input of this data source type to an existing job. </summary>
    public partial class RawReferenceInputDataSource : ReferenceInputDataSource
    {
        /// <summary> Initializes a new instance of RawReferenceInputDataSource. </summary>
        public RawReferenceInputDataSource()
        {
            ReferenceInputDataSourceType = "Raw";
        }

        /// <summary> Initializes a new instance of RawReferenceInputDataSource. </summary>
        /// <param name="referenceInputDataSourceType"> Indicates the type of input data source containing reference data. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="payload"> The JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. </param>
        /// <param name="payloadUri"> The SAS URL to a blob containing the JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. </param>
        internal RawReferenceInputDataSource(string referenceInputDataSourceType, BinaryData payload, Uri payloadUri) : base(referenceInputDataSourceType)
        {
            Payload = payload;
            PayloadUri = payloadUri;
            ReferenceInputDataSourceType = referenceInputDataSourceType ?? "Raw";
        }

        /// <summary>
        /// The JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. 
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Payload { get; set; }
        /// <summary> The SAS URL to a blob containing the JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. </summary>
        public Uri PayloadUri { get; set; }
    }
}
