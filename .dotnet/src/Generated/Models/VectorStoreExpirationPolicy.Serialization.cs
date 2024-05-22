// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.VectorStores
{
    public partial class VectorStoreExpirationPolicy : IJsonModel<VectorStoreExpirationPolicy>
    {
        void IJsonModel<VectorStoreExpirationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreExpirationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreExpirationPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("anchor"u8);
            writer.WriteStringValue(_anchor.ToSerialString());
            writer.WritePropertyName("days"u8);
            writer.WriteNumberValue(_days);
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

        VectorStoreExpirationPolicy IJsonModel<VectorStoreExpirationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreExpirationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreExpirationPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorStoreExpirationPolicy(document.RootElement, options);
        }

        internal static VectorStoreExpirationPolicy DeserializeVectorStoreExpirationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VectorStoreExpirationAnchor anchor = default;
            int days = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anchor"u8))
                {
                    anchor = property.Value.GetString().ToVectorStoreExpirationAnchor();
                    continue;
                }
                if (property.NameEquals("days"u8))
                {
                    days = property.Value.GetInt32();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VectorStoreExpirationPolicy(anchor, days, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VectorStoreExpirationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreExpirationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VectorStoreExpirationPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        VectorStoreExpirationPolicy IPersistableModel<VectorStoreExpirationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreExpirationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVectorStoreExpirationPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VectorStoreExpirationPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VectorStoreExpirationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static VectorStoreExpirationPolicy FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeVectorStoreExpirationPolicy(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}

