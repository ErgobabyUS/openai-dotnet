// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    public partial class StreamingResponseFileSearchCallInProgressUpdate : IJsonModel<StreamingResponseFileSearchCallInProgressUpdate>
    {
        internal StreamingResponseFileSearchCallInProgressUpdate()
        {
        }

        void IJsonModel<StreamingResponseFileSearchCallInProgressUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseFileSearchCallInProgressUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingResponseFileSearchCallInProgressUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output_index") != true)
            {
                writer.WritePropertyName("output_index"u8);
                writer.WriteNumberValue(OutputIndex);
            }
        }

        StreamingResponseFileSearchCallInProgressUpdate IJsonModel<StreamingResponseFileSearchCallInProgressUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (StreamingResponseFileSearchCallInProgressUpdate)JsonModelCreateCore(ref reader, options);

        protected override StreamingResponseUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseFileSearchCallInProgressUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingResponseFileSearchCallInProgressUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingResponseFileSearchCallInProgressUpdate(document.RootElement, options);
        }

        internal static StreamingResponseFileSearchCallInProgressUpdate DeserializeStreamingResponseFileSearchCallInProgressUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesResponseStreamEventType @type = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string itemId = default;
            int outputIndex = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalResponsesResponseStreamEventType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output_index"u8))
                {
                    outputIndex = prop.Value.GetInt32();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new StreamingResponseFileSearchCallInProgressUpdate(@type, additionalBinaryDataProperties, itemId, outputIndex);
        }

        BinaryData IPersistableModel<StreamingResponseFileSearchCallInProgressUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseFileSearchCallInProgressUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingResponseFileSearchCallInProgressUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingResponseFileSearchCallInProgressUpdate IPersistableModel<StreamingResponseFileSearchCallInProgressUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (StreamingResponseFileSearchCallInProgressUpdate)PersistableModelCreateCore(data, options);

        protected override StreamingResponseUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseFileSearchCallInProgressUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeStreamingResponseFileSearchCallInProgressUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingResponseFileSearchCallInProgressUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingResponseFileSearchCallInProgressUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(StreamingResponseFileSearchCallInProgressUpdate streamingResponseFileSearchCallInProgressUpdate)
        {
            if (streamingResponseFileSearchCallInProgressUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(streamingResponseFileSearchCallInProgressUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator StreamingResponseFileSearchCallInProgressUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeStreamingResponseFileSearchCallInProgressUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
