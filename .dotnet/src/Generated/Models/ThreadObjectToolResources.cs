// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The ThreadObjectToolResources. </summary>
    internal partial class ThreadObjectToolResources
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

        /// <summary> Initializes a new instance of <see cref="ThreadObjectToolResources"/>. </summary>
        internal ThreadObjectToolResources()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ThreadObjectToolResources"/>. </summary>
        /// <param name="codeInterpreter"></param>
        /// <param name="fileSearch"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadObjectToolResources(ThreadObjectToolResourcesCodeInterpreter codeInterpreter, ThreadObjectToolResourcesFileSearch fileSearch, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the code interpreter. </summary>
        public ThreadObjectToolResourcesCodeInterpreter CodeInterpreter { get; }
        /// <summary> Gets the file search. </summary>
        public ThreadObjectToolResourcesFileSearch FileSearch { get; }
    }
}
