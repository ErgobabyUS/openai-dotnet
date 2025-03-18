// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    public partial class StreamingChatCompletionUpdate : IJsonModel<StreamingChatCompletionUpdate>
    {
        internal StreamingChatCompletionUpdate()
        {
        }

        void IJsonModel<StreamingChatCompletionUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingChatCompletionUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingChatCompletionUpdate)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (Optional.IsDefined(SystemFingerprint) && _additionalBinaryDataProperties?.ContainsKey("system_fingerprint") != true)
            {
                writer.WritePropertyName("system_fingerprint"u8);
                writer.WriteStringValue(SystemFingerprint);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(CompletionId);
            }
            if (Optional.IsDefined(ServiceTier) && _additionalBinaryDataProperties?.ContainsKey("service_tier") != true)
            {
                writer.WritePropertyName("service_tier"u8);
                writer.WriteStringValue(ServiceTier.Value.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("choices") != true)
            {
                writer.WritePropertyName("choices"u8);
                writer.WriteStartArray();
                foreach (InternalCreateChatCompletionStreamResponseChoice item in Choices)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("created") != true)
            {
                writer.WritePropertyName("created"u8);
                writer.WriteNumberValue(CreatedAt, "U");
            }
            if (Optional.IsDefined(Usage) && _additionalBinaryDataProperties?.ContainsKey("usage") != true)
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage, options);
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

        StreamingChatCompletionUpdate IJsonModel<StreamingChatCompletionUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual StreamingChatCompletionUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingChatCompletionUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingChatCompletionUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingChatCompletionUpdate(document.RootElement, options);
        }

        internal static StreamingChatCompletionUpdate DeserializeStreamingChatCompletionUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string model = default;
            string systemFingerprint = default;
            InternalCreateChatCompletionStreamResponseObject @object = default;
            string completionId = default;
            InternalCreateChatCompletionStreamResponseServiceTier? serviceTier = default;
            IReadOnlyList<InternalCreateChatCompletionStreamResponseChoice> choices = default;
            DateTimeOffset createdAt = default;
            ChatTokenUsage usage = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("model"u8))
                {
                    model = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("system_fingerprint"u8))
                {
                    systemFingerprint = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalCreateChatCompletionStreamResponseObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    completionId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("service_tier"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        serviceTier = null;
                        continue;
                    }
                    serviceTier = new InternalCreateChatCompletionStreamResponseServiceTier(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("choices"u8))
                {
                    List<InternalCreateChatCompletionStreamResponseChoice> array = new List<InternalCreateChatCompletionStreamResponseChoice>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(InternalCreateChatCompletionStreamResponseChoice.DeserializeInternalCreateChatCompletionStreamResponseChoice(item, options));
                    }
                    choices = array;
                    continue;
                }
                if (prop.NameEquals("created"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("usage"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = ChatTokenUsage.DeserializeChatTokenUsage(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new StreamingChatCompletionUpdate(
                model,
                systemFingerprint,
                @object,
                completionId,
                serviceTier,
                choices,
                createdAt,
                usage,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<StreamingChatCompletionUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingChatCompletionUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingChatCompletionUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingChatCompletionUpdate IPersistableModel<StreamingChatCompletionUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual StreamingChatCompletionUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingChatCompletionUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeStreamingChatCompletionUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingChatCompletionUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingChatCompletionUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(StreamingChatCompletionUpdate streamingChatCompletionUpdate)
        {
            if (streamingChatCompletionUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(streamingChatCompletionUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator StreamingChatCompletionUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeStreamingChatCompletionUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
