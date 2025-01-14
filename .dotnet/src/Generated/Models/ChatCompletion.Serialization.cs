// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    public partial class ChatCompletion : IJsonModel<ChatCompletion>
    {
        void IJsonModel<ChatCompletion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletion)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("choices"u8);
            writer.WriteStartArray();
            foreach (var item in Choices)
            {
                writer.WriteObjectValue<InternalCreateChatCompletionResponseChoice>(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("created"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model);
            if (Optional.IsDefined(SystemFingerprint))
            {
                writer.WritePropertyName("system_fingerprint"u8);
                writer.WriteStringValue(SystemFingerprint);
            }
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            if (Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage, options);
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

        ChatCompletion IJsonModel<ChatCompletion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletion)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletion(document.RootElement, options);
        }

        internal static ChatCompletion DeserializeChatCompletion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IReadOnlyList<InternalCreateChatCompletionResponseChoice> choices = default;
            DateTimeOffset created = default;
            string model = default;
            string systemFingerprint = default;
            InternalCreateChatCompletionResponseObject @object = default;
            ChatTokenUsage usage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("choices"u8))
                {
                    List<InternalCreateChatCompletionResponseChoice> array = new List<InternalCreateChatCompletionResponseChoice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InternalCreateChatCompletionResponseChoice.DeserializeInternalCreateChatCompletionResponseChoice(item, options));
                    }
                    choices = array;
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("system_fingerprint"u8))
                {
                    systemFingerprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new InternalCreateChatCompletionResponseObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = ChatTokenUsage.DeserializeChatTokenUsage(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChatCompletion(
                id,
                choices,
                created,
                model,
                systemFingerprint,
                @object,
                usage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatCompletion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletion)} does not support writing '{options.Format}' format.");
            }
        }

        ChatCompletion IPersistableModel<ChatCompletion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletion)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ChatCompletion FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletion(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
