// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    /// <summary> The `fine_tuning.job.checkpoint` object represents a model checkpoint for a fine-tuning job that is ready to use. </summary>
    internal partial class InternalFineTuningJobCheckpoint
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

        /// <summary> Initializes a new instance of <see cref="InternalFineTuningJobCheckpoint"/>. </summary>
        /// <param name="id"> The checkpoint identifier, which can be referenced in the API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the checkpoint was created. </param>
        /// <param name="fineTunedModelCheckpoint"> The name of the fine-tuned checkpoint model that is created. </param>
        /// <param name="stepNumber"> The step number that the checkpoint was created at. </param>
        /// <param name="metrics"> Metrics at the step number during the fine-tuning job. </param>
        /// <param name="fineTuningJobId"> The name of the fine-tuning job that this checkpoint was created from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="fineTunedModelCheckpoint"/>, <paramref name="metrics"/> or <paramref name="fineTuningJobId"/> is null. </exception>
        internal InternalFineTuningJobCheckpoint(string id, DateTimeOffset createdAt, string fineTunedModelCheckpoint, int stepNumber, InternalFineTuningJobCheckpointMetrics metrics, string fineTuningJobId)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(fineTunedModelCheckpoint, nameof(fineTunedModelCheckpoint));
            Argument.AssertNotNull(metrics, nameof(metrics));
            Argument.AssertNotNull(fineTuningJobId, nameof(fineTuningJobId));

            Id = id;
            CreatedAt = createdAt;
            FineTunedModelCheckpoint = fineTunedModelCheckpoint;
            StepNumber = stepNumber;
            Metrics = metrics;
            FineTuningJobId = fineTuningJobId;
        }

        /// <summary> Initializes a new instance of <see cref="InternalFineTuningJobCheckpoint"/>. </summary>
        /// <param name="id"> The checkpoint identifier, which can be referenced in the API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the checkpoint was created. </param>
        /// <param name="fineTunedModelCheckpoint"> The name of the fine-tuned checkpoint model that is created. </param>
        /// <param name="stepNumber"> The step number that the checkpoint was created at. </param>
        /// <param name="metrics"> Metrics at the step number during the fine-tuning job. </param>
        /// <param name="fineTuningJobId"> The name of the fine-tuning job that this checkpoint was created from. </param>
        /// <param name="object"> The object type, which is always "fine_tuning.job.checkpoint". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalFineTuningJobCheckpoint(string id, DateTimeOffset createdAt, string fineTunedModelCheckpoint, int stepNumber, InternalFineTuningJobCheckpointMetrics metrics, string fineTuningJobId, InternalFineTuningJobCheckpointObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CreatedAt = createdAt;
            FineTunedModelCheckpoint = fineTunedModelCheckpoint;
            StepNumber = stepNumber;
            Metrics = metrics;
            FineTuningJobId = fineTuningJobId;
            Object = @object;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalFineTuningJobCheckpoint"/> for deserialization. </summary>
        internal InternalFineTuningJobCheckpoint()
        {
        }

        /// <summary> The checkpoint identifier, which can be referenced in the API endpoints. </summary>
        public string Id { get; }
        /// <summary> The Unix timestamp (in seconds) for when the checkpoint was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The name of the fine-tuned checkpoint model that is created. </summary>
        public string FineTunedModelCheckpoint { get; }
        /// <summary> The step number that the checkpoint was created at. </summary>
        public int StepNumber { get; }
        /// <summary> Metrics at the step number during the fine-tuning job. </summary>
        public InternalFineTuningJobCheckpointMetrics Metrics { get; }
        /// <summary> The name of the fine-tuning job that this checkpoint was created from. </summary>
        public string FineTuningJobId { get; }
        /// <summary> The object type, which is always "fine_tuning.job.checkpoint". </summary>
        public InternalFineTuningJobCheckpointObject Object { get; } = InternalFineTuningJobCheckpointObject.FineTuningJobCheckpoint;
    }
}
