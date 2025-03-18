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
    public partial class OpenAIResponse : IJsonModel<OpenAIResponse>
    {
        internal OpenAIResponse()
        {
        }

        void IJsonModel<OpenAIResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAIResponse)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("created_at") != true)
            {
                writer.WritePropertyName("created_at"u8);
                writer.WriteNumberValue(CreatedAt, "U");
            }
            if (Optional.IsDefined(Status) && _additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("error") != true)
            {
                if (Optional.IsDefined(Error))
                {
                    writer.WritePropertyName("error"u8);
                    writer.WriteObjectValue(Error, options);
                }
                else
                {
                    writer.WriteNull("error"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("instructions") != true)
            {
                if (Optional.IsDefined(Instructions))
                {
                    writer.WritePropertyName("instructions"u8);
                    writer.WriteStringValue(Instructions);
                }
                else
                {
                    writer.WriteNull("instructions"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("previous_response_id") != true)
            {
                if (Optional.IsDefined(PreviousResponseId))
                {
                    writer.WritePropertyName("previous_response_id"u8);
                    writer.WriteStringValue(PreviousResponseId);
                }
                else
                {
                    writer.WriteNull("previous_response_id"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("temperature") != true)
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("tools") != true)
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (ResponseTool item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("top_p") != true)
            {
                writer.WritePropertyName("top_p"u8);
                writer.WriteNumberValue(TopP);
            }
            if (Optional.IsDefined(Usage) && _additionalBinaryDataProperties?.ContainsKey("usage") != true)
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("metadata") != true)
            {
                if (Optional.IsCollectionDefined(Metadata))
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
            }
            if (Optional.IsDefined(EndUserId) && _additionalBinaryDataProperties?.ContainsKey("user") != true)
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(EndUserId);
            }
            if (Optional.IsDefined(ReasoningOptions) && _additionalBinaryDataProperties?.ContainsKey("reasoning") != true)
            {
                writer.WritePropertyName("reasoning"u8);
                writer.WriteObjectValue(ReasoningOptions, options);
            }
            if (Optional.IsDefined(MaxOutputTokenCount) && _additionalBinaryDataProperties?.ContainsKey("max_output_tokens") != true)
            {
                writer.WritePropertyName("max_output_tokens"u8);
                writer.WriteNumberValue(MaxOutputTokenCount.Value);
            }
            if (Optional.IsDefined(TextOptions) && _additionalBinaryDataProperties?.ContainsKey("text") != true)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteObjectValue(TextOptions, options);
            }
            if (Optional.IsDefined(TruncationMode) && _additionalBinaryDataProperties?.ContainsKey("truncation") != true)
            {
                writer.WritePropertyName("truncation"u8);
                writer.WriteStringValue(TruncationMode.Value.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("incomplete_details") != true)
            {
                if (Optional.IsDefined(IncompleteStatusDetails))
                {
                    writer.WritePropertyName("incomplete_details"u8);
                    writer.WriteObjectValue(IncompleteStatusDetails, options);
                }
                else
                {
                    writer.WriteNull("incomplete_details"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output") != true)
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStartArray();
                foreach (ResponseItem item in OutputItems)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("parallel_tool_calls") != true)
            {
                writer.WritePropertyName("parallel_tool_calls"u8);
                writer.WriteBooleanValue(ParallelToolCallsEnabled);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("tool_choice") != true)
            {
                writer.WritePropertyName("tool_choice"u8);
                writer.WriteObjectValue(ToolChoice, options);
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

        OpenAIResponse IJsonModel<OpenAIResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual OpenAIResponse JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAIResponse)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenAIResponse(document.RootElement, options);
        }

        internal static OpenAIResponse DeserializeOpenAIResponse(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            DateTimeOffset createdAt = default;
            ResponseStatus? status = default;
            ResponseError error = default;
            string instructions = default;
            string model = default;
            string previousResponseId = default;
            float temperature = default;
            IList<ResponseTool> tools = default;
            float topP = default;
            ResponseTokenUsage usage = default;
            IDictionary<string, string> metadata = default;
            InternalCreateResponsesResponseObject @object = default;
            string endUserId = default;
            ResponseReasoningOptions reasoningOptions = default;
            int? maxOutputTokenCount = default;
            ResponseTextOptions textOptions = default;
            ResponseTruncationMode? truncationMode = default;
            ResponseIncompleteStatusDetails incompleteStatusDetails = default;
            IList<ResponseItem> outputItems = default;
            bool parallelToolCallsEnabled = default;
            ResponseToolChoice toolChoice = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = prop.Value.GetString().ToResponseStatus();
                    continue;
                }
                if (prop.NameEquals("error"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = ResponseError.DeserializeResponseError(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("instructions"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        instructions = null;
                        continue;
                    }
                    instructions = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("model"u8))
                {
                    model = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("previous_response_id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        previousResponseId = null;
                        continue;
                    }
                    previousResponseId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("temperature"u8))
                {
                    temperature = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("tools"u8))
                {
                    List<ResponseTool> array = new List<ResponseTool>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ResponseTool.DeserializeResponseTool(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (prop.NameEquals("top_p"u8))
                {
                    topP = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("usage"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = ResponseTokenUsage.DeserializeResponseTokenUsage(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("metadata"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        if (prop0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(prop0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(prop0.Name, prop0.Value.GetString());
                        }
                    }
                    metadata = dictionary;
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalCreateResponsesResponseObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("user"u8))
                {
                    endUserId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("reasoning"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        reasoningOptions = null;
                        continue;
                    }
                    reasoningOptions = ResponseReasoningOptions.DeserializeResponseReasoningOptions(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("max_output_tokens"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxOutputTokenCount = null;
                        continue;
                    }
                    maxOutputTokenCount = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("text"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    textOptions = ResponseTextOptions.DeserializeResponseTextOptions(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("truncation"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        truncationMode = null;
                        continue;
                    }
                    truncationMode = new ResponseTruncationMode(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("incomplete_details"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        incompleteStatusDetails = null;
                        continue;
                    }
                    incompleteStatusDetails = ResponseIncompleteStatusDetails.DeserializeResponseIncompleteStatusDetails(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("output"u8))
                {
                    List<ResponseItem> array = new List<ResponseItem>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ResponseItem.DeserializeResponseItem(item, options));
                    }
                    outputItems = array;
                    continue;
                }
                if (prop.NameEquals("parallel_tool_calls"u8))
                {
                    parallelToolCallsEnabled = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("tool_choice"u8))
                {
                    toolChoice = ResponseToolChoice.DeserializeResponseToolChoice(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new OpenAIResponse(
                id,
                createdAt,
                status,
                error,
                instructions,
                model,
                previousResponseId,
                temperature,
                tools,
                topP,
                usage,
                metadata,
                @object,
                endUserId,
                reasoningOptions,
                maxOutputTokenCount,
                textOptions,
                truncationMode,
                incompleteStatusDetails,
                outputItems,
                parallelToolCallsEnabled,
                toolChoice,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<OpenAIResponse>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OpenAIResponse)} does not support writing '{options.Format}' format.");
            }
        }

        OpenAIResponse IPersistableModel<OpenAIResponse>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual OpenAIResponse PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeOpenAIResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenAIResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenAIResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(OpenAIResponse openAIResponse)
        {
            if (openAIResponse == null)
            {
                return null;
            }
            return BinaryContent.Create(openAIResponse, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator OpenAIResponse(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeOpenAIResponse(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
