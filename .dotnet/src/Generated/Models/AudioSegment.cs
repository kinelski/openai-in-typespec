// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Internal.Models
{
    /// <summary> The AudioSegment. </summary>
    internal partial class AudioSegment
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

        /// <summary> Initializes a new instance of <see cref="AudioSegment"/>. </summary>
        /// <param name="id"> The zero-based index of this segment. </param>
        /// <param name="seek">
        /// The seek position associated with the processing of this audio segment. Seek positions are
        /// expressed as hundredths of seconds. The model may process several segments from a single seek
        /// position, so while the seek position will never represent a later time than the segment's
        /// start, the segment's start may represent a significantly later time than the segment's
        /// associated seek position.
        /// </param>
        /// <param name="start"> The time at which this segment started relative to the beginning of the audio. </param>
        /// <param name="end"> The time at which this segment ended relative to the beginning of the audio. </param>
        /// <param name="text"> The text that was part of this audio segment. </param>
        /// <param name="tokens"> The token IDs matching the text in this audio segment. </param>
        /// <param name="temperature"> The temperature score associated with this audio segment. </param>
        /// <param name="avgLogprob"> The average log probability associated with this audio segment. </param>
        /// <param name="compressionRatio"> The compression ratio of this audio segment. </param>
        /// <param name="noSpeechProb"> The probability of no speech detection within this audio segment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="tokens"/> is null. </exception>
        internal AudioSegment(long id, long seek, TimeSpan start, TimeSpan end, string text, IEnumerable<long> tokens, double temperature, double avgLogprob, double compressionRatio, double noSpeechProb)
        {
            if (text is null) throw new ArgumentNullException(nameof(text));
            if (tokens is null) throw new ArgumentNullException(nameof(tokens));

            Id = id;
            Seek = seek;
            Start = start;
            End = end;
            Text = text;
            Tokens = tokens.ToList();
            Temperature = temperature;
            AvgLogprob = avgLogprob;
            CompressionRatio = compressionRatio;
            NoSpeechProb = noSpeechProb;
        }

        /// <summary> Initializes a new instance of <see cref="AudioSegment"/>. </summary>
        /// <param name="id"> The zero-based index of this segment. </param>
        /// <param name="seek">
        /// The seek position associated with the processing of this audio segment. Seek positions are
        /// expressed as hundredths of seconds. The model may process several segments from a single seek
        /// position, so while the seek position will never represent a later time than the segment's
        /// start, the segment's start may represent a significantly later time than the segment's
        /// associated seek position.
        /// </param>
        /// <param name="start"> The time at which this segment started relative to the beginning of the audio. </param>
        /// <param name="end"> The time at which this segment ended relative to the beginning of the audio. </param>
        /// <param name="text"> The text that was part of this audio segment. </param>
        /// <param name="tokens"> The token IDs matching the text in this audio segment. </param>
        /// <param name="temperature"> The temperature score associated with this audio segment. </param>
        /// <param name="avgLogprob"> The average log probability associated with this audio segment. </param>
        /// <param name="compressionRatio"> The compression ratio of this audio segment. </param>
        /// <param name="noSpeechProb"> The probability of no speech detection within this audio segment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AudioSegment(long id, long seek, TimeSpan start, TimeSpan end, string text, IReadOnlyList<long> tokens, double temperature, double avgLogprob, double compressionRatio, double noSpeechProb, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Seek = seek;
            Start = start;
            End = end;
            Text = text;
            Tokens = tokens;
            Temperature = temperature;
            AvgLogprob = avgLogprob;
            CompressionRatio = compressionRatio;
            NoSpeechProb = noSpeechProb;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AudioSegment"/> for deserialization. </summary>
        internal AudioSegment()
        {
        }

        /// <summary> The zero-based index of this segment. </summary>
        public long Id { get; }
        /// <summary>
        /// The seek position associated with the processing of this audio segment. Seek positions are
        /// expressed as hundredths of seconds. The model may process several segments from a single seek
        /// position, so while the seek position will never represent a later time than the segment's
        /// start, the segment's start may represent a significantly later time than the segment's
        /// associated seek position.
        /// </summary>
        public long Seek { get; }
        /// <summary> The time at which this segment started relative to the beginning of the audio. </summary>
        public TimeSpan Start { get; }
        /// <summary> The time at which this segment ended relative to the beginning of the audio. </summary>
        public TimeSpan End { get; }
        /// <summary> The text that was part of this audio segment. </summary>
        public string Text { get; }
        /// <summary> The token IDs matching the text in this audio segment. </summary>
        public IReadOnlyList<long> Tokens { get; }
        /// <summary> The temperature score associated with this audio segment. </summary>
        public double Temperature { get; }
        /// <summary> The average log probability associated with this audio segment. </summary>
        public double AvgLogprob { get; }
        /// <summary> The compression ratio of this audio segment. </summary>
        public double CompressionRatio { get; }
        /// <summary> The probability of no speech detection within this audio segment. </summary>
        public double NoSpeechProb { get; }
    }
}