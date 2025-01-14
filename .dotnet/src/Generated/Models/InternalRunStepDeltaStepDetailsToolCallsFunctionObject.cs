// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> The RunStepDeltaStepDetailsToolCallsFunctionObject. </summary>
    internal partial class InternalRunStepDeltaStepDetailsToolCallsFunctionObject : InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject
    {
        /// <summary> Initializes a new instance of <see cref="InternalRunStepDeltaStepDetailsToolCallsFunctionObject"/>. </summary>
        /// <param name="index"> The index of the tool call in the tool calls array. </param>
        internal InternalRunStepDeltaStepDetailsToolCallsFunctionObject(int index)
        {
            Type = "function";
            Index = index;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDeltaStepDetailsToolCallsFunctionObject"/>. </summary>
        /// <param name="type"> The discriminated type identifier for the details object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="index"> The index of the tool call in the tool calls array. </param>
        /// <param name="id"> The ID of the tool call object. </param>
        /// <param name="function"> The definition of the function that was called. </param>
        internal InternalRunStepDeltaStepDetailsToolCallsFunctionObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, int index, string id, InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction function) : base(type, serializedAdditionalRawData)
        {
            Index = index;
            Id = id;
            Function = function;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDeltaStepDetailsToolCallsFunctionObject"/> for deserialization. </summary>
        internal InternalRunStepDeltaStepDetailsToolCallsFunctionObject()
        {
        }

        /// <summary> The index of the tool call in the tool calls array. </summary>
        public int Index { get; }
        /// <summary> The ID of the tool call object. </summary>
        public string Id { get; }
        /// <summary> The definition of the function that was called. </summary>
        public InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction Function { get; }
    }
}
