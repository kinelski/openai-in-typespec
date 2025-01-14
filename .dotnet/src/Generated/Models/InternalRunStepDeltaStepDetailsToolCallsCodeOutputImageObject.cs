// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> The RunStepDeltaStepDetailsToolCallsCodeOutputImageObject. </summary>
    internal partial class InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject : RunStepUpdateCodeInterpreterOutput
    {
        /// <summary> Initializes a new instance of <see cref="InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject"/>. </summary>
        /// <param name="index"> The index of the output in the outputs array. </param>
        internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject(int index)
        {
            Type = "image";
            Index = index;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject"/>. </summary>
        /// <param name="type"> The discriminated type identifier for the details object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="index"> The index of the output in the outputs array. </param>
        /// <param name="image"></param>
        internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, int index, InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage image) : base(type, serializedAdditionalRawData)
        {
            Index = index;
            Image = image;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject"/> for deserialization. </summary>
        internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject()
        {
        }

        /// <summary> The index of the output in the outputs array. </summary>
        public int Index { get; }
        /// <summary> Gets the image. </summary>
        public InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage Image { get; }
    }
}
