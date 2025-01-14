// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionRequestMessageContentPartImageImageUrl : IJsonModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>
    {
        void IJsonModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImageImageUrl)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            if (Optional.IsDefined(Detail))
            {
                writer.WritePropertyName("detail"u8);
                writer.WriteStringValue(Detail.Value.ToString());
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

        InternalChatCompletionRequestMessageContentPartImageImageUrl IJsonModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImageImageUrl)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatCompletionRequestMessageContentPartImageImageUrl(document.RootElement, options);
        }

        internal static InternalChatCompletionRequestMessageContentPartImageImageUrl DeserializeInternalChatCompletionRequestMessageContentPartImageImageUrl(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string url = default;
            ImageChatMessageContentPartDetail? detail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detail = new ImageChatMessageContentPartDetail(property.Value.GetString());
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalChatCompletionRequestMessageContentPartImageImageUrl(url, detail, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImageImageUrl)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatCompletionRequestMessageContentPartImageImageUrl IPersistableModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalChatCompletionRequestMessageContentPartImageImageUrl(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImageImageUrl)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatCompletionRequestMessageContentPartImageImageUrl>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static InternalChatCompletionRequestMessageContentPartImageImageUrl FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalChatCompletionRequestMessageContentPartImageImageUrl(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
