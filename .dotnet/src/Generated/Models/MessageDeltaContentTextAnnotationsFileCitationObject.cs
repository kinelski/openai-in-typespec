// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files. </summary>
    internal partial class MessageDeltaContentTextAnnotationsFileCitationObject : MessageDeltaTextContentAnnotation
    {
        /// <summary> Initializes a new instance of <see cref="MessageDeltaContentTextAnnotationsFileCitationObject"/>. </summary>
        /// <param name="index"> The index of the annotation in the text content part. </param>
        internal MessageDeltaContentTextAnnotationsFileCitationObject(int index)
        {
            Type = "file_citation";
            Index = index;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaContentTextAnnotationsFileCitationObject"/>. </summary>
        /// <param name="type"> The discriminated type identifier for the content item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="index"> The index of the annotation in the text content part. </param>
        /// <param name="text"> The text in the message content that needs to be replaced. </param>
        /// <param name="fileCitation"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        internal MessageDeltaContentTextAnnotationsFileCitationObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, int index, string text, MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation fileCitation, int? startIndex, int? endIndex) : base(type, serializedAdditionalRawData)
        {
            Index = index;
            Text = text;
            FileCitation = fileCitation;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaContentTextAnnotationsFileCitationObject"/> for deserialization. </summary>
        internal MessageDeltaContentTextAnnotationsFileCitationObject()
        {
        }

        /// <summary> The index of the annotation in the text content part. </summary>
        public int Index { get; }
        /// <summary> The text in the message content that needs to be replaced. </summary>
        public string Text { get; }
        /// <summary> Gets the file citation. </summary>
        public MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation FileCitation { get; }
        /// <summary> Gets the start index. </summary>
        public int? StartIndex { get; }
        /// <summary> Gets the end index. </summary>
        public int? EndIndex { get; }
    }
}
