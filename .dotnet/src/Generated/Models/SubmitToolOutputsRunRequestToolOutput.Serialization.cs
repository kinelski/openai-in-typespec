// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class SubmitToolOutputsRunRequestToolOutput : IJsonModel<SubmitToolOutputsRunRequestToolOutput>
    {
        void IJsonModel<SubmitToolOutputsRunRequestToolOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsRunRequestToolOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubmitToolOutputsRunRequestToolOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(ToolCallId))
            {
                writer.WritePropertyName("tool_call_id"u8);
                writer.WriteStringValue(ToolCallId);
            }
            if (OptionalProperty.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStringValue(Output);
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

        SubmitToolOutputsRunRequestToolOutput IJsonModel<SubmitToolOutputsRunRequestToolOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsRunRequestToolOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubmitToolOutputsRunRequestToolOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubmitToolOutputsRunRequestToolOutput(document.RootElement, options);
        }

        internal static SubmitToolOutputsRunRequestToolOutput DeserializeSubmitToolOutputsRunRequestToolOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> toolCallId = default;
            OptionalProperty<string> output = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tool_call_id"u8))
                {
                    toolCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    output = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubmitToolOutputsRunRequestToolOutput(toolCallId.Value, output.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubmitToolOutputsRunRequestToolOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsRunRequestToolOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubmitToolOutputsRunRequestToolOutput)} does not support '{options.Format}' format.");
            }
        }

        SubmitToolOutputsRunRequestToolOutput IPersistableModel<SubmitToolOutputsRunRequestToolOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsRunRequestToolOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubmitToolOutputsRunRequestToolOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubmitToolOutputsRunRequestToolOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubmitToolOutputsRunRequestToolOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static SubmitToolOutputsRunRequestToolOutput FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSubmitToolOutputsRunRequestToolOutput(document.RootElement);
        }
    }
}