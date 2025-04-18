// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Images
{
    public partial class GeneratedImage : IJsonModel<GeneratedImage>
    {
        void IJsonModel<GeneratedImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeneratedImage)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(RevisedPrompt) && _additionalBinaryDataProperties?.ContainsKey("revised_prompt") != true)
            {
                writer.WritePropertyName("revised_prompt"u8);
                writer.WriteStringValue(RevisedPrompt);
            }
            if (Optional.IsDefined(ImageBytes) && _additionalBinaryDataProperties?.ContainsKey("b64_json") != true)
            {
                writer.WritePropertyName("b64_json"u8);
                writer.WriteBase64StringValue(ImageBytes.ToArray(), "D");
            }
            if (Optional.IsDefined(ImageUri) && _additionalBinaryDataProperties?.ContainsKey("url") != true)
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(ImageUri.AbsoluteUri);
            }
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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
        }

        GeneratedImage IJsonModel<GeneratedImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual GeneratedImage JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeneratedImage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGeneratedImage(document.RootElement, options);
        }

        internal static GeneratedImage DeserializeGeneratedImage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string revisedPrompt = default;
            BinaryData imageBytes = default;
            Uri imageUri = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("revised_prompt"u8))
                {
                    revisedPrompt = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("b64_json"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageBytes = BinaryData.FromBytes(prop.Value.GetBytesFromBase64("D"));
                    continue;
                }
                if (prop.NameEquals("url"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageUri = new Uri(prop.Value.GetString());
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new GeneratedImage(revisedPrompt, imageBytes, imageUri, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<GeneratedImage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GeneratedImage)} does not support writing '{options.Format}' format.");
            }
        }

        GeneratedImage IPersistableModel<GeneratedImage>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual GeneratedImage PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeGeneratedImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GeneratedImage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GeneratedImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(GeneratedImage generatedImage)
        {
            if (generatedImage == null)
            {
                return null;
            }
            return BinaryContent.Create(generatedImage, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator GeneratedImage(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeGeneratedImage(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
