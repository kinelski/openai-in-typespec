// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionFunctionResponseChoice : IJsonModel<InternalCreateChatCompletionFunctionResponseChoice>
    {
        void IJsonModel<InternalCreateChatCompletionFunctionResponseChoice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("finish_reason"u8);
            writer.WriteStringValue(FinishReason);
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            writer.WritePropertyName("message"u8);
            writer.WriteObjectValue(Message, options);
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

        InternalCreateChatCompletionFunctionResponseChoice IJsonModel<InternalCreateChatCompletionFunctionResponseChoice>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateChatCompletionFunctionResponseChoice(document.RootElement, options);
        }

        internal static InternalCreateChatCompletionFunctionResponseChoice DeserializeInternalCreateChatCompletionFunctionResponseChoice(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string finishReason = default;
            int index = default;
            InternalChatCompletionResponseMessage message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("finish_reason"u8))
                {
                    finishReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = InternalChatCompletionResponseMessage.DeserializeInternalChatCompletionResponseMessage(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalCreateChatCompletionFunctionResponseChoice(finishReason, index, message, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateChatCompletionFunctionResponseChoice IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalCreateChatCompletionFunctionResponseChoice(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static InternalCreateChatCompletionFunctionResponseChoice FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateChatCompletionFunctionResponseChoice(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
