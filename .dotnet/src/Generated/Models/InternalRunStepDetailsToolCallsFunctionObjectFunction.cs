// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> The RunStepDetailsToolCallsFunctionObjectFunction. </summary>
    internal partial class InternalRunStepDetailsToolCallsFunctionObjectFunction
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

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDetailsToolCallsFunctionObjectFunction"/>. </summary>
        /// <param name="name"> The name of the function. </param>
        /// <param name="arguments"> The arguments passed to the function. </param>
        /// <param name="output"> The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="arguments"/> is null. </exception>
        internal InternalRunStepDetailsToolCallsFunctionObjectFunction(string name, string arguments, string output)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(arguments, nameof(arguments));

            Name = name;
            Arguments = arguments;
            Output = output;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDetailsToolCallsFunctionObjectFunction"/>. </summary>
        /// <param name="name"> The name of the function. </param>
        /// <param name="arguments"> The arguments passed to the function. </param>
        /// <param name="output"> The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalRunStepDetailsToolCallsFunctionObjectFunction(string name, string arguments, string output, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Arguments = arguments;
            Output = output;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDetailsToolCallsFunctionObjectFunction"/> for deserialization. </summary>
        internal InternalRunStepDetailsToolCallsFunctionObjectFunction()
        {
        }

        /// <summary> The name of the function. </summary>
        public string Name { get; }
        /// <summary> The arguments passed to the function. </summary>
        public string Arguments { get; }
        /// <summary> The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet. </summary>
        public string Output { get; }
    }
}
