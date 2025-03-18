// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    public partial class ResponseContentPart : IJsonModel<ResponseContentPart>
    {
        internal ResponseContentPart()
        {
        }

        void IJsonModel<ResponseContentPart>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseContentPart>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseContentPart)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(InternalType.ToString());
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

        ResponseContentPart IJsonModel<ResponseContentPart>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ResponseContentPart JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseContentPart>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseContentPart)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResponseContentPart(document.RootElement, options);
        }

        internal static ResponseContentPart DeserializeResponseContentPart(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "input_text":
                        return InternalResponsesInputTextContentPart.DeserializeInternalResponsesInputTextContentPart(element, options);
                    case "input_image":
                        return InternalResponsesInputImageContentPart.DeserializeInternalResponsesInputImageContentPart(element, options);
                    case "input_file":
                        return InternalResponsesInputFileContentPart.DeserializeInternalResponsesInputFileContentPart(element, options);
                    case "output_text":
                        return InternalResponsesOutputTextContentPart.DeserializeInternalResponsesOutputTextContentPart(element, options);
                    case "refusal":
                        return InternalResponsesOutputRefusalContentPart.DeserializeInternalResponsesOutputRefusalContentPart(element, options);
                }
            }
            return InternalUnknownResponsesContent.DeserializeInternalUnknownResponsesContent(element, options);
        }

        BinaryData IPersistableModel<ResponseContentPart>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseContentPart>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResponseContentPart)} does not support writing '{options.Format}' format.");
            }
        }

        ResponseContentPart IPersistableModel<ResponseContentPart>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ResponseContentPart PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseContentPart>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeResponseContentPart(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResponseContentPart)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResponseContentPart>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ResponseContentPart responseContentPart)
        {
            if (responseContentPart == null)
            {
                return null;
            }
            return BinaryContent.Create(responseContentPart, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ResponseContentPart(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeResponseContentPart(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
