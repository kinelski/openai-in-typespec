// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    public partial class ChatTokenLogProbabilityInfo : IJsonModel<ChatTokenLogProbabilityInfo>
    {
        void IJsonModel<ChatTokenLogProbabilityInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenLogProbabilityInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("token"u8);
            writer.WriteStringValue(Token);
            writer.WritePropertyName("logprob"u8);
            writer.WriteNumberValue(LogProbability);
            if (Utf8ByteValues != null && Optional.IsCollectionDefined(Utf8ByteValues))
            {
                writer.WritePropertyName("bytes"u8);
                writer.WriteStartArray();
                foreach (var item in Utf8ByteValues)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("bytes");
            }
            writer.WritePropertyName("top_logprobs"u8);
            writer.WriteStartArray();
            foreach (var item in TopLogProbabilities)
            {
                writer.WriteObjectValue<ChatTokenTopLogProbabilityInfo>(item, options);
            }
            writer.WriteEndArray();
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

        ChatTokenLogProbabilityInfo IJsonModel<ChatTokenLogProbabilityInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenLogProbabilityInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatTokenLogProbabilityInfo(document.RootElement, options);
        }

        internal static ChatTokenLogProbabilityInfo DeserializeChatTokenLogProbabilityInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            float logprob = default;
            IReadOnlyList<int> bytes = default;
            IReadOnlyList<ChatTokenTopLogProbabilityInfo> topLogprobs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logprob"u8))
                {
                    logprob = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bytes = new ChangeTrackingList<int>();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    bytes = array;
                    continue;
                }
                if (property.NameEquals("top_logprobs"u8))
                {
                    List<ChatTokenTopLogProbabilityInfo> array = new List<ChatTokenTopLogProbabilityInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatTokenTopLogProbabilityInfo.DeserializeChatTokenTopLogProbabilityInfo(item, options));
                    }
                    topLogprobs = array;
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChatTokenLogProbabilityInfo(token, logprob, bytes, topLogprobs, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatTokenLogProbabilityInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatTokenLogProbabilityInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ChatTokenLogProbabilityInfo IPersistableModel<ChatTokenLogProbabilityInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatTokenLogProbabilityInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatTokenLogProbabilityInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatTokenLogProbabilityInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ChatTokenLogProbabilityInfo FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatTokenLogProbabilityInfo(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}

