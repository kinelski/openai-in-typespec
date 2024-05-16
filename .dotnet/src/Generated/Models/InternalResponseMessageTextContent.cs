// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Models;

namespace OpenAI.Assistants
{
    /// <summary> The text content that is part of a message. </summary>
    internal partial class InternalResponseMessageTextContent : MessageContent
    {
        /// <summary> Initializes a new instance of <see cref="InternalResponseMessageTextContent"/>. </summary>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="type"> Always `text`. </param>
        /// <param name="text"></param>
        internal InternalResponseMessageTextContent(IDictionary<string, BinaryData> serializedAdditionalRawData, string type, MessageContentTextObjectText text) : base(serializedAdditionalRawData)
        {
            _type = type;
            _text = text;
        }

        /// <summary> Initializes a new instance of <see cref="InternalResponseMessageTextContent"/> for deserialization. </summary>
        internal InternalResponseMessageTextContent()
        {
        }
    }
}