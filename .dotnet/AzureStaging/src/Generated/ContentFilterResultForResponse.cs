// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A content filter result for a single response item produced by a generative AI system. </summary>
    public partial class ContentFilterResultForResponse
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContentFilterResultForResponse"/>. </summary>
        internal ContentFilterResultForResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterResultForResponse"/>. </summary>
        /// <param name="sexual">
        /// A content filter category for language related to anatomical organs and genitals, romantic relationships, acts
        /// portrayed in erotic or affectionate terms, pregnancy, physical sexual acts, including those portrayed as an
        /// assault or a forced sexual violent act against one's will, prostitution, pornography, and abuse.
        /// </param>
        /// <param name="hate">
        /// A content filter category that can refer to any content that attacks or uses pejorative or discriminatory
        /// language with reference to a person or identity group based on certain differentiating attributes of these groups
        /// including but not limited to race, ethnicity, nationality, gender identity and expression, sexual orientation,
        /// religion, immigration status, ability status, personal appearance, and body size.
        /// </param>
        /// <param name="violence">
        /// A content filter category for language related to physical actions intended to hurt, injure, damage, or kill
        /// someone or something; describes weapons, guns and related entities, such as manufactures, associations,
        /// legislation, and so on.
        /// </param>
        /// <param name="selfHarm">
        /// A content filter category that describes language related to physical actions intended to purposely hurt, injure,
        /// damage one's body or kill oneself.
        /// </param>
        /// <param name="profanity">
        /// A detection result that identifies whether crude, vulgar, or otherwise objection language is present in the
        /// content.
        /// </param>
        /// <param name="customBlocklists"> A collection of binary filtering outcomes for configured custom blocklists. </param>
        /// <param name="error"> If present, details about an error that prevented content filtering from completing its evaluation. </param>
        /// <param name="protectedMaterialText"> A detection result that describes a match against text protected under copyright or other status. </param>
        /// <param name="protectedMaterialCode"> A detection result that describes a match against licensed code or other protected source material. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentFilterResultForResponse(ContentFilterSeverityResult sexual, ContentFilterSeverityResult hate, ContentFilterSeverityResult violence, ContentFilterSeverityResult selfHarm, ContentFilterDetectionResult profanity, ContentFilterBlocklistResult customBlocklists, InternalAzureContentFilterResultForPromptContentFilterResultsError error, ContentFilterDetectionResult protectedMaterialText, ContentFilterProtectedMaterialResult protectedMaterialCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sexual = sexual;
            Hate = hate;
            Violence = violence;
            SelfHarm = selfHarm;
            Profanity = profanity;
            CustomBlocklists = customBlocklists;
            Error = error;
            ProtectedMaterialText = protectedMaterialText;
            ProtectedMaterialCode = protectedMaterialCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// A content filter category for language related to anatomical organs and genitals, romantic relationships, acts
        /// portrayed in erotic or affectionate terms, pregnancy, physical sexual acts, including those portrayed as an
        /// assault or a forced sexual violent act against one's will, prostitution, pornography, and abuse.
        /// </summary>
        public ContentFilterSeverityResult Sexual { get; }
        /// <summary>
        /// A content filter category that can refer to any content that attacks or uses pejorative or discriminatory
        /// language with reference to a person or identity group based on certain differentiating attributes of these groups
        /// including but not limited to race, ethnicity, nationality, gender identity and expression, sexual orientation,
        /// religion, immigration status, ability status, personal appearance, and body size.
        /// </summary>
        public ContentFilterSeverityResult Hate { get; }
        /// <summary>
        /// A content filter category for language related to physical actions intended to hurt, injure, damage, or kill
        /// someone or something; describes weapons, guns and related entities, such as manufactures, associations,
        /// legislation, and so on.
        /// </summary>
        public ContentFilterSeverityResult Violence { get; }
        /// <summary>
        /// A content filter category that describes language related to physical actions intended to purposely hurt, injure,
        /// damage one's body or kill oneself.
        /// </summary>
        public ContentFilterSeverityResult SelfHarm { get; }
        /// <summary>
        /// A detection result that identifies whether crude, vulgar, or otherwise objection language is present in the
        /// content.
        /// </summary>
        public ContentFilterDetectionResult Profanity { get; }
        /// <summary> A collection of binary filtering outcomes for configured custom blocklists. </summary>
        public ContentFilterBlocklistResult CustomBlocklists { get; }
        /// <summary> A detection result that describes a match against text protected under copyright or other status. </summary>
        public ContentFilterDetectionResult ProtectedMaterialText { get; }
        /// <summary> A detection result that describes a match against licensed code or other protected source material. </summary>
        public ContentFilterProtectedMaterialResult ProtectedMaterialCode { get; }
    }
}