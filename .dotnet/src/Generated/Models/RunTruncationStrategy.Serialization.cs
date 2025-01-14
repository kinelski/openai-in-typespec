// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    public partial class RunTruncationStrategy : IJsonModel<RunTruncationStrategy>
    {
        void IJsonModel<RunTruncationStrategy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunTruncationStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunTruncationStrategy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(_type.ToString());
            if (Optional.IsDefined(LastMessages))
            {
                if (LastMessages != null)
                {
                    writer.WritePropertyName("last_messages"u8);
                    writer.WriteNumberValue(LastMessages.Value);
                }
                else
                {
                    writer.WriteNull("last_messages");
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

        RunTruncationStrategy IJsonModel<RunTruncationStrategy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunTruncationStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunTruncationStrategy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunTruncationStrategy(document.RootElement, options);
        }

        internal static RunTruncationStrategy DeserializeRunTruncationStrategy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRunTruncationStrategyType type = default;
            int? lastMessages = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new InternalRunTruncationStrategyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("last_messages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastMessages = null;
                        continue;
                    }
                    lastMessages = property.Value.GetInt32();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RunTruncationStrategy(type, lastMessages, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunTruncationStrategy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunTruncationStrategy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunTruncationStrategy)} does not support writing '{options.Format}' format.");
            }
        }

        RunTruncationStrategy IPersistableModel<RunTruncationStrategy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunTruncationStrategy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunTruncationStrategy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunTruncationStrategy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunTruncationStrategy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RunTruncationStrategy FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunTruncationStrategy(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
