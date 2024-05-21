// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The AzureContentFilterImageResponseResults. </summary>
    public partial class ImageResponseContentFilterResult
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ImageResponseContentFilterResult"/>. </summary>
        internal ImageResponseContentFilterResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageResponseContentFilterResult"/>. </summary>
        /// <param name="sexual"></param>
        /// <param name="violence"></param>
        /// <param name="hate"></param>
        /// <param name="selfHarm"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageResponseContentFilterResult(ContentFilterSeverityResult sexual, ContentFilterSeverityResult violence, ContentFilterSeverityResult hate, ContentFilterSeverityResult selfHarm, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sexual = sexual;
            Violence = violence;
            Hate = hate;
            SelfHarm = selfHarm;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the sexual. </summary>
        public ContentFilterSeverityResult Sexual { get; }
        /// <summary> Gets the violence. </summary>
        public ContentFilterSeverityResult Violence { get; }
        /// <summary> Gets the hate. </summary>
        public ContentFilterSeverityResult Hate { get; }
        /// <summary> Gets the self harm. </summary>
        public ContentFilterSeverityResult SelfHarm { get; }
    }
}