// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class BatchRequestOutput : IJsonModel<BatchRequestOutput>
    {
        void IJsonModel<BatchRequestOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchRequestOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchRequestOutput)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(CustomId))
            {
                writer.WritePropertyName("custom_id"u8);
                writer.WriteStringValue(CustomId);
            }
            if (Optional.IsDefined(Response))
            {
                if (Response != null)
                {
                    writer.WritePropertyName("response"u8);
                    writer.WriteObjectValue(Response, options);
                }
                else
                {
                    writer.WriteNull("response");
                }
            }
            if (Optional.IsDefined(Error))
            {
                if (Error != null)
                {
                    writer.WritePropertyName("error"u8);
                    writer.WriteObjectValue(Error, options);
                }
                else
                {
                    writer.WriteNull("error");
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

        BatchRequestOutput IJsonModel<BatchRequestOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchRequestOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchRequestOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchRequestOutput(document.RootElement, options);
        }

        internal static BatchRequestOutput DeserializeBatchRequestOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string customId = default;
            BatchRequestOutputResponse response = default;
            BatchRequestOutputError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("custom_id"u8))
                {
                    customId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        response = null;
                        continue;
                    }
                    response = BatchRequestOutputResponse.DeserializeBatchRequestOutputResponse(property.Value, options);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = BatchRequestOutputError.DeserializeBatchRequestOutputError(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchRequestOutput(id, customId, response, error, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchRequestOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchRequestOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchRequestOutput)} does not support writing '{options.Format}' format.");
            }
        }

        BatchRequestOutput IPersistableModel<BatchRequestOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchRequestOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchRequestOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchRequestOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchRequestOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static BatchRequestOutput FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchRequestOutput(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
