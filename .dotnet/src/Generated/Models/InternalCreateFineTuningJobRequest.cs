// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    /// <summary> The CreateFineTuningJobRequest. </summary>
    internal partial class InternalCreateFineTuningJobRequest
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

        /// <summary> Initializes a new instance of <see cref="InternalCreateFineTuningJobRequest"/>. </summary>
        /// <param name="model">
        /// The name of the model to fine-tune. You can select one of the
        /// [supported models](/docs/guides/fine-tuning/what-models-can-be-fine-tuned).
        /// </param>
        /// <param name="trainingFile">
        /// The ID of an uploaded file that contains training data.
        ///
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.
        ///
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.
        ///
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingFile"/> is null. </exception>
        public InternalCreateFineTuningJobRequest(InternalCreateFineTuningJobRequestModel model, string trainingFile)
        {
            Argument.AssertNotNull(trainingFile, nameof(trainingFile));

            Model = model;
            TrainingFile = trainingFile;
            Integrations = new ChangeTrackingList<InternalCreateFineTuningJobRequestIntegration>();
        }

        /// <summary> Initializes a new instance of <see cref="InternalCreateFineTuningJobRequest"/>. </summary>
        /// <param name="model">
        /// The name of the model to fine-tune. You can select one of the
        /// [supported models](/docs/guides/fine-tuning/what-models-can-be-fine-tuned).
        /// </param>
        /// <param name="trainingFile">
        /// The ID of an uploaded file that contains training data.
        ///
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.
        ///
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.
        ///
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </param>
        /// <param name="hyperparameters"> The hyperparameters used for the fine-tuning job. </param>
        /// <param name="suffix">
        /// A string of up to 18 characters that will be added to your fine-tuned model name.
        ///
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-3.5-turbo:openai:custom-model-name:7p4lURel`.
        /// </param>
        /// <param name="validationFile">
        /// The ID of an uploaded file that contains validation data.
        ///
        /// If you provide this file, the data is used to generate validation
        /// metrics periodically during fine-tuning. These metrics can be viewed in
        /// the fine-tuning results file.
        /// The same data should not be present in both train and validation files.
        ///
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.
        ///
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </param>
        /// <param name="integrations"> A list of integrations to enable for your fine-tuning job. </param>
        /// <param name="seed">
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.
        /// If a seed is not specified, one will be generated for you.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalCreateFineTuningJobRequest(InternalCreateFineTuningJobRequestModel model, string trainingFile, InternalCreateFineTuningJobRequestHyperparameters hyperparameters, string suffix, string validationFile, IList<InternalCreateFineTuningJobRequestIntegration> integrations, int? seed, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            TrainingFile = trainingFile;
            Hyperparameters = hyperparameters;
            Suffix = suffix;
            ValidationFile = validationFile;
            Integrations = integrations;
            Seed = seed;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalCreateFineTuningJobRequest"/> for deserialization. </summary>
        internal InternalCreateFineTuningJobRequest()
        {
        }

        /// <summary>
        /// The name of the model to fine-tune. You can select one of the
        /// [supported models](/docs/guides/fine-tuning/what-models-can-be-fine-tuned).
        /// </summary>
        public InternalCreateFineTuningJobRequestModel Model { get; }
        /// <summary>
        /// The ID of an uploaded file that contains training data.
        ///
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.
        ///
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.
        ///
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </summary>
        public string TrainingFile { get; }
        /// <summary> The hyperparameters used for the fine-tuning job. </summary>
        public InternalCreateFineTuningJobRequestHyperparameters Hyperparameters { get; set; }
        /// <summary>
        /// A string of up to 18 characters that will be added to your fine-tuned model name.
        ///
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-3.5-turbo:openai:custom-model-name:7p4lURel`.
        /// </summary>
        public string Suffix { get; set; }
        /// <summary>
        /// The ID of an uploaded file that contains validation data.
        ///
        /// If you provide this file, the data is used to generate validation
        /// metrics periodically during fine-tuning. These metrics can be viewed in
        /// the fine-tuning results file.
        /// The same data should not be present in both train and validation files.
        ///
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.
        ///
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// </summary>
        public string ValidationFile { get; set; }
        /// <summary> A list of integrations to enable for your fine-tuning job. </summary>
        public IList<InternalCreateFineTuningJobRequestIntegration> Integrations { get; set; }
        /// <summary>
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.
        /// If a seed is not specified, one will be generated for you.
        /// </summary>
        public int? Seed { get; set; }
    }
}
