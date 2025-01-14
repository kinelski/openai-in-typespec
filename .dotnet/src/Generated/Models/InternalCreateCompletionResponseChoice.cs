// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.LegacyCompletions
{
    /// <summary> The CreateCompletionResponseChoice. </summary>
    internal partial class InternalCreateCompletionResponseChoice
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

        /// <summary> Initializes a new instance of <see cref="InternalCreateCompletionResponseChoice"/>. </summary>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
        /// `length` if the maximum number of tokens specified in the request was reached,
        /// or `content_filter` if content was omitted due to a flag from our content filters.
        /// </param>
        /// <param name="index"></param>
        /// <param name="logprobs"></param>
        /// <param name="text"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal InternalCreateCompletionResponseChoice(InternalCreateCompletionResponseChoiceFinishReason finishReason, int index, InternalCreateCompletionResponseChoiceLogprobs logprobs, string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            FinishReason = finishReason;
            Index = index;
            Logprobs = logprobs;
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="InternalCreateCompletionResponseChoice"/>. </summary>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
        /// `length` if the maximum number of tokens specified in the request was reached,
        /// or `content_filter` if content was omitted due to a flag from our content filters.
        /// </param>
        /// <param name="index"></param>
        /// <param name="logprobs"></param>
        /// <param name="text"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalCreateCompletionResponseChoice(InternalCreateCompletionResponseChoiceFinishReason finishReason, int index, InternalCreateCompletionResponseChoiceLogprobs logprobs, string text, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FinishReason = finishReason;
            Index = index;
            Logprobs = logprobs;
            Text = text;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalCreateCompletionResponseChoice"/> for deserialization. </summary>
        internal InternalCreateCompletionResponseChoice()
        {
        }

        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
        /// `length` if the maximum number of tokens specified in the request was reached,
        /// or `content_filter` if content was omitted due to a flag from our content filters.
        /// </summary>
        public InternalCreateCompletionResponseChoiceFinishReason FinishReason { get; }
        /// <summary> Gets the index. </summary>
        public int Index { get; }
        /// <summary> Gets the logprobs. </summary>
        public InternalCreateCompletionResponseChoiceLogprobs Logprobs { get; }
        /// <summary> Gets the text. </summary>
        public string Text { get; }
    }
}
