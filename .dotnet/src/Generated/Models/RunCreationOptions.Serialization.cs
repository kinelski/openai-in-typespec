// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    public partial class RunCreationOptions : IJsonModel<RunCreationOptions>
    {
        void IJsonModel<RunCreationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCreationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunCreationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
            if (Optional.IsDefined(ModelOverride))
            {
                if (ModelOverride != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteStringValue(ModelOverride);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (Optional.IsDefined(InstructionsOverride))
            {
                if (InstructionsOverride != null)
                {
                    writer.WritePropertyName("instructions"u8);
                    writer.WriteStringValue(InstructionsOverride);
                }
                else
                {
                    writer.WriteNull("instructions");
                }
            }
            if (Optional.IsDefined(AdditionalInstructions))
            {
                if (AdditionalInstructions != null)
                {
                    writer.WritePropertyName("additional_instructions"u8);
                    writer.WriteStringValue(AdditionalInstructions);
                }
                else
                {
                    writer.WriteNull("additional_instructions");
                }
            }
            if (Optional.IsCollectionDefined(InternalMessages))
            {
                if (InternalMessages != null)
                {
                    writer.WritePropertyName("additional_messages"u8);
                    writer.WriteStartArray();
                    foreach (var item in InternalMessages)
                    {
                        writer.WriteObjectValue<MessageCreationOptions>(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("additional_messages");
                }
            }
            if (Optional.IsCollectionDefined(ToolsOverride))
            {
                if (ToolsOverride != null)
                {
                    writer.WritePropertyName("tools"u8);
                    writer.WriteStartArray();
                    foreach (var item in ToolsOverride)
                    {
                        writer.WriteObjectValue<ToolDefinition>(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("tools");
                }
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                if (Metadata != null)
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata");
                }
            }
            if (Optional.IsDefined(Temperature))
            {
                if (Temperature != null)
                {
                    writer.WritePropertyName("temperature"u8);
                    writer.WriteNumberValue(Temperature.Value);
                }
                else
                {
                    writer.WriteNull("temperature");
                }
            }
            if (Optional.IsDefined(NucleusSamplingFactor))
            {
                if (NucleusSamplingFactor != null)
                {
                    writer.WritePropertyName("top_p"u8);
                    writer.WriteNumberValue(NucleusSamplingFactor.Value);
                }
                else
                {
                    writer.WriteNull("top_p");
                }
            }
            if (Optional.IsDefined(Stream))
            {
                if (Stream != null)
                {
                    writer.WritePropertyName("stream"u8);
                    writer.WriteBooleanValue(Stream.Value);
                }
                else
                {
                    writer.WriteNull("stream");
                }
            }
            if (Optional.IsDefined(MaxPromptTokens))
            {
                if (MaxPromptTokens != null)
                {
                    writer.WritePropertyName("max_prompt_tokens"u8);
                    writer.WriteNumberValue(MaxPromptTokens.Value);
                }
                else
                {
                    writer.WriteNull("max_prompt_tokens");
                }
            }
            if (Optional.IsDefined(MaxCompletionTokens))
            {
                if (MaxCompletionTokens != null)
                {
                    writer.WritePropertyName("max_completion_tokens"u8);
                    writer.WriteNumberValue(MaxCompletionTokens.Value);
                }
                else
                {
                    writer.WriteNull("max_completion_tokens");
                }
            }
            if (Optional.IsDefined(TruncationStrategy))
            {
                if (TruncationStrategy != null)
                {
                    writer.WritePropertyName("truncation_strategy"u8);
                    writer.WriteObjectValue<RunTruncationStrategy>(TruncationStrategy, options);
                }
                else
                {
                    writer.WriteNull("truncation_strategy");
                }
            }
            if (Optional.IsDefined(ToolConstraint))
            {
                if (ToolConstraint != null)
                {
                    writer.WritePropertyName("tool_choice"u8);
                    SerializeToolConstraint(writer);
                }
                else
                {
                    writer.WriteNull("tool_choice");
                }
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                if (ResponseFormat != null)
                {
                    writer.WritePropertyName("response_format"u8);
                    writer.WriteObjectValue<AssistantResponseFormat>(ResponseFormat, options);
                }
                else
                {
                    writer.WriteNull("response_format");
                }
            }
            if (true && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RunCreationOptions IJsonModel<RunCreationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCreationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunCreationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunCreationOptions(document.RootElement, options);
        }

        internal static RunCreationOptions DeserializeRunCreationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assistantId = default;
            string model = default;
            string instructions = default;
            string additionalInstructions = default;
            IList<MessageCreationOptions> additionalMessages = default;
            IList<ToolDefinition> tools = default;
            IDictionary<string, string> metadata = default;
            float? temperature = default;
            float? topP = default;
            bool? stream = default;
            int? maxPromptTokens = default;
            int? maxCompletionTokens = default;
            RunTruncationStrategy truncationStrategy = default;
            ToolConstraint toolChoice = default;
            AssistantResponseFormat responseFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assistant_id"u8))
                {
                    assistantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instructions = null;
                        continue;
                    }
                    instructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additional_instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        additionalInstructions = null;
                        continue;
                    }
                    additionalInstructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additional_messages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MessageCreationOptions> array = new List<MessageCreationOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MessageCreationOptions.DeserializeMessageCreationOptions(item, options));
                    }
                    additionalMessages = array;
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ToolDefinition> array = new List<ToolDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ToolDefinition.DeserializeToolDefinition(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        temperature = null;
                        continue;
                    }
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("top_p"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        topP = null;
                        continue;
                    }
                    topP = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stream"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stream = null;
                        continue;
                    }
                    stream = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("max_prompt_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxPromptTokens = null;
                        continue;
                    }
                    maxPromptTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("max_completion_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxCompletionTokens = null;
                        continue;
                    }
                    maxCompletionTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("truncation_strategy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        truncationStrategy = null;
                        continue;
                    }
                    truncationStrategy = RunTruncationStrategy.DeserializeRunTruncationStrategy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tool_choice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        toolChoice = null;
                        continue;
                    }
                    toolChoice = Assistants.ToolConstraint.DeserializeToolConstraint(property.Value, options);
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        responseFormat = null;
                        continue;
                    }
                    responseFormat = AssistantResponseFormat.DeserializeAssistantResponseFormat(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RunCreationOptions(
                assistantId,
                model,
                instructions,
                additionalInstructions,
                additionalMessages ?? new ChangeTrackingList<MessageCreationOptions>(),
                tools ?? new ChangeTrackingList<ToolDefinition>(),
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                temperature,
                topP,
                stream,
                maxPromptTokens,
                maxCompletionTokens,
                truncationStrategy,
                toolChoice,
                responseFormat,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunCreationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCreationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunCreationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        RunCreationOptions IPersistableModel<RunCreationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCreationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunCreationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunCreationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunCreationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RunCreationOptions FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunCreationOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
