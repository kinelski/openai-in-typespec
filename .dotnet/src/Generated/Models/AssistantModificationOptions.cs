// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> The ModifyAssistantRequest. </summary>
    public partial class AssistantModificationOptions
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

        /// <summary> Initializes a new instance of <see cref="AssistantModificationOptions"/>. </summary>
        public AssistantModificationOptions()
        {
            DefaultTools = new ChangeTrackingList<ToolDefinition>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AssistantModificationOptions"/>. </summary>
        /// <param name="model"> ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. </param>
        /// <param name="name"> The name of the assistant. The maximum length is 256 characters. </param>
        /// <param name="description"> The description of the assistant. The maximum length is 512 characters. </param>
        /// <param name="instructions"> The system instructions that the assistant uses. The maximum length is 256,000 characters. </param>
        /// <param name="defaultTools">
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FileSearchToolDefinition"/> and <see cref="FunctionToolDefinition"/>.
        /// </param>
        /// <param name="toolResources"> A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs. </param>
        /// <param name="metadata"> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </param>
        /// <param name="temperature"> What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. </param>
        /// <param name="nucleusSamplingFactor">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or temperature but not both.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssistantModificationOptions(string model, string name, string description, string instructions, IList<ToolDefinition> defaultTools, ToolResources toolResources, IDictionary<string, string> metadata, float? temperature, float? nucleusSamplingFactor, AssistantResponseFormat responseFormat, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            Name = name;
            Description = description;
            Instructions = instructions;
            DefaultTools = defaultTools;
            ToolResources = toolResources;
            Metadata = metadata;
            Temperature = temperature;
            NucleusSamplingFactor = nucleusSamplingFactor;
            ResponseFormat = responseFormat;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> The name of the assistant. The maximum length is 256 characters. </summary>
        public string Name { get; init; }
        /// <summary> The description of the assistant. The maximum length is 512 characters. </summary>
        public string Description { get; init; }
        /// <summary> The system instructions that the assistant uses. The maximum length is 256,000 characters. </summary>
        public string Instructions { get; init; }
        /// <summary> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. </summary>
        public float? Temperature { get; init; }
    }
}
