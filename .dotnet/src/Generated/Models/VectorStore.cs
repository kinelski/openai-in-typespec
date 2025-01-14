// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Models;

namespace OpenAI.VectorStores
{
    /// <summary> A vector store is a collection of processed files can be used by the `file_search` tool. </summary>
    public partial class VectorStore
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

        /// <summary> Initializes a new instance of <see cref="VectorStore"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the vector store was created. </param>
        /// <param name="name"> The name of the vector store. </param>
        /// <param name="usageBytes"> The total number of bytes used by the files in the vector store. </param>
        /// <param name="fileCounts"></param>
        /// <param name="status"> The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use. </param>
        /// <param name="lastActiveAt"> The Unix timestamp (in seconds) for when the vector store was last active. </param>
        /// <param name="metadata"> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="name"/> is null. </exception>
        internal VectorStore(string id, DateTimeOffset createdAt, string name, int usageBytes, VectorStoreFileCounts fileCounts, VectorStoreStatus status, DateTimeOffset? lastActiveAt, IReadOnlyDictionary<string, string> metadata)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(name, nameof(name));

            Id = id;
            CreatedAt = createdAt;
            Name = name;
            UsageBytes = usageBytes;
            FileCounts = fileCounts;
            Status = status;
            LastActiveAt = lastActiveAt;
            Metadata = metadata;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStore"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `vector_store`. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the vector store was created. </param>
        /// <param name="name"> The name of the vector store. </param>
        /// <param name="usageBytes"> The total number of bytes used by the files in the vector store. </param>
        /// <param name="fileCounts"></param>
        /// <param name="status"> The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use. </param>
        /// <param name="expirationPolicy"></param>
        /// <param name="expiresAt"> The Unix timestamp (in seconds) for when the vector store will expire. </param>
        /// <param name="lastActiveAt"> The Unix timestamp (in seconds) for when the vector store was last active. </param>
        /// <param name="metadata"> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VectorStore(string id, object @object, DateTimeOffset createdAt, string name, int usageBytes, VectorStoreFileCounts fileCounts, VectorStoreStatus status, VectorStoreExpirationPolicy expirationPolicy, DateTimeOffset? expiresAt, DateTimeOffset? lastActiveAt, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            Name = name;
            UsageBytes = usageBytes;
            FileCounts = fileCounts;
            Status = status;
            ExpirationPolicy = expirationPolicy;
            ExpiresAt = expiresAt;
            LastActiveAt = lastActiveAt;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStore"/> for deserialization. </summary>
        internal VectorStore()
        {
        }

        /// <summary> The identifier, which can be referenced in API endpoints. </summary>
        public string Id { get; }

        /// <summary> The Unix timestamp (in seconds) for when the vector store was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The name of the vector store. </summary>
        public string Name { get; }
        /// <summary> The total number of bytes used by the files in the vector store. </summary>
        public int UsageBytes { get; }
        /// <summary> Gets the file counts. </summary>
        public VectorStoreFileCounts FileCounts { get; }
        /// <summary> The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use. </summary>
        public VectorStoreStatus Status { get; }
        /// <summary> The Unix timestamp (in seconds) for when the vector store will expire. </summary>
        public DateTimeOffset? ExpiresAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the vector store was last active. </summary>
        public DateTimeOffset? LastActiveAt { get; }
        /// <summary> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
