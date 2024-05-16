// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class CreateChatCompletionStreamResponseChoiceLogprobs : IJsonModel<CreateChatCompletionStreamResponseChoiceLogprobs>
    {
        void IJsonModel<CreateChatCompletionStreamResponseChoiceLogprobs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateChatCompletionStreamResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateChatCompletionStreamResponseChoiceLogprobs)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Content != null && Optional.IsCollectionDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStartArray();
                foreach (var item in Content)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("content");
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        CreateChatCompletionStreamResponseChoiceLogprobs IJsonModel<CreateChatCompletionStreamResponseChoiceLogprobs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateChatCompletionStreamResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateChatCompletionStreamResponseChoiceLogprobs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateChatCompletionStreamResponseChoiceLogprobs(document.RootElement, options);
        }

        internal static CreateChatCompletionStreamResponseChoiceLogprobs DeserializeCreateChatCompletionStreamResponseChoiceLogprobs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ChatCompletionTokenLogprob> content = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        content = new ChangeTrackingList<ChatCompletionTokenLogprob>();
                        continue;
                    }
                    List<ChatCompletionTokenLogprob> array = new List<ChatCompletionTokenLogprob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatCompletionTokenLogprob.DeserializeChatCompletionTokenLogprob(item, options));
                    }
                    content = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CreateChatCompletionStreamResponseChoiceLogprobs(content, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateChatCompletionStreamResponseChoiceLogprobs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateChatCompletionStreamResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateChatCompletionStreamResponseChoiceLogprobs)} does not support writing '{options.Format}' format.");
            }
        }

        CreateChatCompletionStreamResponseChoiceLogprobs IPersistableModel<CreateChatCompletionStreamResponseChoiceLogprobs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateChatCompletionStreamResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateChatCompletionStreamResponseChoiceLogprobs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateChatCompletionStreamResponseChoiceLogprobs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateChatCompletionStreamResponseChoiceLogprobs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateChatCompletionStreamResponseChoiceLogprobs FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateChatCompletionStreamResponseChoiceLogprobs(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}