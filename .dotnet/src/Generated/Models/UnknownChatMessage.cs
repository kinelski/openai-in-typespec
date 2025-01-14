// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    /// <summary> Unknown version of ChatCompletionRequestMessage. </summary>
    internal partial class UnknownChatMessage : ChatMessage
    {
        /// <summary> Initializes a new instance of <see cref="UnknownChatMessage"/>. </summary>
        /// <param name="role"> The role of the author of this message. </param>
        /// <param name="content"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownChatMessage(string role, IList<ChatMessageContentPart> content, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(role, content, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownChatMessage"/> for deserialization. </summary>
        internal UnknownChatMessage()
        {
        }
    }
}
