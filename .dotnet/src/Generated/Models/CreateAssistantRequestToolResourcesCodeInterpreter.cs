// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateAssistantRequestToolResourcesCodeInterpreter. </summary>
    internal partial class CreateAssistantRequestToolResourcesCodeInterpreter
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

        /// <summary> Initializes a new instance of <see cref="CreateAssistantRequestToolResourcesCodeInterpreter"/>. </summary>
        public CreateAssistantRequestToolResourcesCodeInterpreter()
        {
            FileIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateAssistantRequestToolResourcesCodeInterpreter"/>. </summary>
        /// <param name="fileIds"> A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateAssistantRequestToolResourcesCodeInterpreter(IList<string> fileIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileIds = fileIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool. </summary>
        public IList<string> FileIds { get; }
    }
}
