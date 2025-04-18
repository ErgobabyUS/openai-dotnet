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
    internal partial class InternalModifyThreadRequestToolResourcesCodeInterpreter : IJsonModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>
    {
        void IJsonModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalModifyThreadRequestToolResourcesCodeInterpreter)} does not support writing '{format}' format.");
            }
            if (Optional.IsCollectionDefined(FileIds) && _additionalBinaryDataProperties?.ContainsKey("file_ids") != true)
            {
                writer.WritePropertyName("file_ids"u8);
                writer.WriteStartArray();
                foreach (string item in FileIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        InternalModifyThreadRequestToolResourcesCodeInterpreter IJsonModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalModifyThreadRequestToolResourcesCodeInterpreter JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalModifyThreadRequestToolResourcesCodeInterpreter)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalModifyThreadRequestToolResourcesCodeInterpreter(document.RootElement, options);
        }

        internal static InternalModifyThreadRequestToolResourcesCodeInterpreter DeserializeInternalModifyThreadRequestToolResourcesCodeInterpreter(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> fileIds = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("file_ids"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    fileIds = array;
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalModifyThreadRequestToolResourcesCodeInterpreter(fileIds ?? new ChangeTrackingList<string>(), additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalModifyThreadRequestToolResourcesCodeInterpreter)} does not support writing '{options.Format}' format.");
            }
        }

        InternalModifyThreadRequestToolResourcesCodeInterpreter IPersistableModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalModifyThreadRequestToolResourcesCodeInterpreter PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalModifyThreadRequestToolResourcesCodeInterpreter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalModifyThreadRequestToolResourcesCodeInterpreter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalModifyThreadRequestToolResourcesCodeInterpreter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalModifyThreadRequestToolResourcesCodeInterpreter internalModifyThreadRequestToolResourcesCodeInterpreter)
        {
            if (internalModifyThreadRequestToolResourcesCodeInterpreter == null)
            {
                return null;
            }
            return BinaryContent.Create(internalModifyThreadRequestToolResourcesCodeInterpreter, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalModifyThreadRequestToolResourcesCodeInterpreter(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalModifyThreadRequestToolResourcesCodeInterpreter(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
