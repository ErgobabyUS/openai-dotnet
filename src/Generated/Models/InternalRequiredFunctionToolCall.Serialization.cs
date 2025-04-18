// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRequiredFunctionToolCall : IJsonModel<InternalRequiredFunctionToolCall>
    {
        internal InternalRequiredFunctionToolCall()
        {
        }

        void IJsonModel<InternalRequiredFunctionToolCall>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteObjectValue<object>(_type, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("function") != true)
            {
                writer.WritePropertyName("function"u8);
                writer.WriteObjectValue(_internalFunction, options);
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

        InternalRequiredFunctionToolCall IJsonModel<InternalRequiredFunctionToolCall>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRequiredFunctionToolCall JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRequiredFunctionToolCall(document.RootElement, options);
        }

        internal static InternalRequiredFunctionToolCall DeserializeInternalRequiredFunctionToolCall(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            object @type = default;
            InternalRunToolCallObjectFunction internalFunction = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetObject();
                    continue;
                }
                if (prop.NameEquals("function"u8))
                {
                    internalFunction = InternalRunToolCallObjectFunction.DeserializeInternalRunToolCallObjectFunction(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRequiredFunctionToolCall(id, @type, internalFunction, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRequiredFunctionToolCall>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRequiredFunctionToolCall IPersistableModel<InternalRequiredFunctionToolCall>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRequiredFunctionToolCall PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRequiredFunctionToolCall(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRequiredFunctionToolCall>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRequiredFunctionToolCall internalRequiredFunctionToolCall)
        {
            if (internalRequiredFunctionToolCall == null)
            {
                return null;
            }
            return BinaryContent.Create(internalRequiredFunctionToolCall, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRequiredFunctionToolCall(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRequiredFunctionToolCall(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
