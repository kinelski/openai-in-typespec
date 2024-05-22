// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    /// <summary> The ChatCompletionMessageToolCallChunk. </summary>
    public partial class StreamingChatToolCallUpdate
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
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamingChatToolCallUpdate"/>. </summary>
        /// <param name="index"></param>
        /// <param name="id"> The ID of the tool call. </param>
        /// <param name="kind"> The type of the tool. Currently, only `function` is supported. </param>
        /// <param name="function"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingChatToolCallUpdate(int index, string id, ChatToolCallKind kind, InternalChatCompletionMessageToolCallChunkFunction function, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Index = index;
            Id = id;
            Kind = kind;
            Function = function;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamingChatToolCallUpdate"/> for deserialization. </summary>
        internal StreamingChatToolCallUpdate()
        {
        }

        /// <summary> Gets the index. </summary>
        public int Index { get; }
        /// <summary> The ID of the tool call. </summary>
        public string Id { get; }
    }
}
