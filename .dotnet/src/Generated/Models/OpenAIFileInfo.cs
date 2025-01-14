// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Files
{
    /// <summary> The `File` object represents a document that has been uploaded to OpenAI. </summary>
    public partial class OpenAIFileInfo
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

        /// <summary> Initializes a new instance of <see cref="OpenAIFileInfo"/>. </summary>
        /// <param name="id"> The file identifier, which can be referenced in the API endpoints. </param>
        /// <param name="sizeInBytes"> The size of the file, in bytes. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the file was created. </param>
        /// <param name="filename"> The name of the file. </param>
        /// <param name="purpose"> The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`. </param>
        /// <param name="status"> Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="filename"/> is null. </exception>
        internal OpenAIFileInfo(string id, long? sizeInBytes, DateTimeOffset createdAt, string filename, OpenAIFilePurpose purpose, OpenAIFileStatus status)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(filename, nameof(filename));

            Id = id;
            SizeInBytes = sizeInBytes;
            CreatedAt = createdAt;
            Filename = filename;
            Purpose = purpose;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="OpenAIFileInfo"/>. </summary>
        /// <param name="id"> The file identifier, which can be referenced in the API endpoints. </param>
        /// <param name="sizeInBytes"> The size of the file, in bytes. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the file was created. </param>
        /// <param name="filename"> The name of the file. </param>
        /// <param name="object"> The object type, which is always `file`. </param>
        /// <param name="purpose"> The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`. </param>
        /// <param name="status"> Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`. </param>
        /// <param name="statusDetails"> Deprecated. For details on why a fine-tuning training file failed validation, see the `error` field on `fine_tuning.job`. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OpenAIFileInfo(string id, long? sizeInBytes, DateTimeOffset createdAt, string filename, InternalOpenAIFileObject @object, OpenAIFilePurpose purpose, OpenAIFileStatus status, string statusDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            SizeInBytes = sizeInBytes;
            CreatedAt = createdAt;
            Filename = filename;
            Object = @object;
            Purpose = purpose;
            Status = status;
            StatusDetails = statusDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OpenAIFileInfo"/> for deserialization. </summary>
        internal OpenAIFileInfo()
        {
        }

        /// <summary> The file identifier, which can be referenced in the API endpoints. </summary>
        public string Id { get; }
        /// <summary> The Unix timestamp (in seconds) for when the file was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The name of the file. </summary>
        public string Filename { get; }

        /// <summary> The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`. </summary>
        public OpenAIFilePurpose Purpose { get; }
        /// <summary> Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`. </summary>
        public OpenAIFileStatus Status { get; }
        /// <summary> Deprecated. For details on why a fine-tuning training file failed validation, see the `error` field on `fine_tuning.job`. </summary>
        public string StatusDetails { get; }
    }
}
