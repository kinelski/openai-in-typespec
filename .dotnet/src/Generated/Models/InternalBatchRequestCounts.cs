// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Batch
{
    /// <summary> The BatchRequestCounts. </summary>
    internal readonly partial struct InternalBatchRequestCounts
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
        private readonly IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InternalBatchRequestCounts"/>. </summary>
        /// <param name="total"> Total number of requests in the batch. </param>
        /// <param name="completed"> Number of requests that have been completed successfully. </param>
        /// <param name="failed"> Number of requests that have failed. </param>
        internal InternalBatchRequestCounts(int total, int completed, int failed)
        {
            Total = total;
            Completed = completed;
            Failed = failed;
        }

        /// <summary> Initializes a new instance of <see cref="InternalBatchRequestCounts"/>. </summary>
        /// <param name="total"> Total number of requests in the batch. </param>
        /// <param name="completed"> Number of requests that have been completed successfully. </param>
        /// <param name="failed"> Number of requests that have failed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalBatchRequestCounts(int total, int completed, int failed, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Total = total;
            Completed = completed;
            Failed = failed;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalBatchRequestCounts"/> for deserialization. </summary>
        public InternalBatchRequestCounts()
        {
        }

        /// <summary> Total number of requests in the batch. </summary>
        public int Total { get; }
        /// <summary> Number of requests that have been completed successfully. </summary>
        public int Completed { get; }
        /// <summary> Number of requests that have failed. </summary>
        public int Failed { get; }
    }
}
