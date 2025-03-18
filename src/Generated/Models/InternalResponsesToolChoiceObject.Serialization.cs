// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    [PersistableModelProxy(typeof(InternalUnknownResponsesToolChoiceObject))]
    internal abstract partial class InternalResponsesToolChoiceObject : IJsonModel<InternalResponsesToolChoiceObject>
    {
        internal InternalResponsesToolChoiceObject()
        {
        }

        void IJsonModel<InternalResponsesToolChoiceObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesToolChoiceObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesToolChoiceObject)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.ToString());
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

        InternalResponsesToolChoiceObject IJsonModel<InternalResponsesToolChoiceObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalResponsesToolChoiceObject JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesToolChoiceObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesToolChoiceObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesToolChoiceObject(document.RootElement, options);
        }

        internal static InternalResponsesToolChoiceObject DeserializeInternalResponsesToolChoiceObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "function":
                        return InternalResponsesToolChoiceObjectFunction.DeserializeInternalResponsesToolChoiceObjectFunction(element, options);
                    case "file_search":
                        return InternalResponsesToolChoiceObjectFileSearch.DeserializeInternalResponsesToolChoiceObjectFileSearch(element, options);
                    case "web_search_preview":
                        return InternalResponsesToolChoiceObjectWebSearch.DeserializeInternalResponsesToolChoiceObjectWebSearch(element, options);
                    case "computer_use_preview":
                        return InternalResponsesToolChoiceObjectComputer.DeserializeInternalResponsesToolChoiceObjectComputer(element, options);
                }
            }
            return InternalUnknownResponsesToolChoiceObject.DeserializeInternalUnknownResponsesToolChoiceObject(element, options);
        }

        BinaryData IPersistableModel<InternalResponsesToolChoiceObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesToolChoiceObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesToolChoiceObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesToolChoiceObject IPersistableModel<InternalResponsesToolChoiceObject>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalResponsesToolChoiceObject PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesToolChoiceObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesToolChoiceObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesToolChoiceObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesToolChoiceObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesToolChoiceObject internalResponsesToolChoiceObject)
        {
            if (internalResponsesToolChoiceObject == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesToolChoiceObject, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesToolChoiceObject(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesToolChoiceObject(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
