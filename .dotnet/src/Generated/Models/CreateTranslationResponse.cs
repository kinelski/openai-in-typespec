// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateTranslationResponse. </summary>
    internal partial class CreateTranslationResponse
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

        /// <summary> Initializes a new instance of <see cref="CreateTranslationResponse"/>. </summary>
        /// <param name="text"> The translated text for the provided audio data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal CreateTranslationResponse(string text)
        {
            if (text is null) throw new ArgumentNullException(nameof(text));

            Text = text;
            Segments = new OptionalList<AudioSegment>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateTranslationResponse"/>. </summary>
        /// <param name="text"> The translated text for the provided audio data. </param>
        /// <param name="task"> The label that describes which operation type generated the accompanying response data. </param>
        /// <param name="language"> The spoken language that was detected in the audio data. </param>
        /// <param name="duration"> The total duration of the audio processed to produce accompanying translation information. </param>
        /// <param name="segments">
        /// A collection of information about the timing, probabilities, and other detail of each processed
        /// audio segment.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateTranslationResponse(string text, CreateTranslationResponseTask? task, string language, TimeSpan? duration, IReadOnlyList<AudioSegment> segments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Task = task;
            Language = language;
            Duration = duration;
            Segments = segments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateTranslationResponse"/> for deserialization. </summary>
        internal CreateTranslationResponse()
        {
        }

        /// <summary> The translated text for the provided audio data. </summary>
        public string Text { get; }
        /// <summary> The label that describes which operation type generated the accompanying response data. </summary>
        public CreateTranslationResponseTask? Task { get; }
        /// <summary> The spoken language that was detected in the audio data. </summary>
        public string Language { get; }
        /// <summary> The total duration of the audio processed to produce accompanying translation information. </summary>
        public TimeSpan? Duration { get; }
        /// <summary>
        /// A collection of information about the timing, probabilities, and other detail of each processed
        /// audio segment.
        /// </summary>
        public IReadOnlyList<AudioSegment> Segments { get; }
    }
}
