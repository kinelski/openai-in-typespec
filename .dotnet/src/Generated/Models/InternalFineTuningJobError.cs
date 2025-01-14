// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    /// <summary> The FineTuningJobError. </summary>
    internal partial class InternalFineTuningJobError
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

        /// <summary> Initializes a new instance of <see cref="InternalFineTuningJobError"/>. </summary>
        /// <param name="code"> A machine-readable error code. </param>
        /// <param name="message"> A human-readable error message. </param>
        /// <param name="param"> The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal InternalFineTuningJobError(string code, string message, string param)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Param = param;
        }

        /// <summary> Initializes a new instance of <see cref="InternalFineTuningJobError"/>. </summary>
        /// <param name="code"> A machine-readable error code. </param>
        /// <param name="message"> A human-readable error message. </param>
        /// <param name="param"> The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalFineTuningJobError(string code, string message, string param, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Param = param;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalFineTuningJobError"/> for deserialization. </summary>
        internal InternalFineTuningJobError()
        {
        }

        /// <summary> A machine-readable error code. </summary>
        public string Code { get; }
        /// <summary> A human-readable error message. </summary>
        public string Message { get; }
        /// <summary> The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific. </summary>
        public string Param { get; }
    }
}
