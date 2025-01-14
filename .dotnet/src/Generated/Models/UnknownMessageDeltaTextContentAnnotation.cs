// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> Unknown version of MessageDeltaTextContentAnnotation. </summary>
    internal partial class UnknownMessageDeltaTextContentAnnotation : MessageDeltaTextContentAnnotation
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMessageDeltaTextContentAnnotation"/>. </summary>
        /// <param name="type"> The discriminated type identifier for the content item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMessageDeltaTextContentAnnotation(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMessageDeltaTextContentAnnotation"/> for deserialization. </summary>
        internal UnknownMessageDeltaTextContentAnnotation()
        {
        }
    }
}
