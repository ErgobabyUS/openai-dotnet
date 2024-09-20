// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject : IJsonModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>
    {
        void IJsonModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("ranker") != true)
            {
                writer.WritePropertyName("ranker"u8);
                writer.WriteStringValue(Ranker.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("score_threshold") != true)
            {
                writer.WritePropertyName("score_threshold"u8);
                writer.WriteNumberValue(ScoreThreshold);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
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
            writer.WriteEndObject();
        }

        InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject IJsonModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsToolCallsFileSearchRankingOptionsObject(document.RootElement, options);
        }

        internal static InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject DeserializeInternalRunStepDetailsToolCallsFileSearchRankingOptionsObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker ranker = default;
            float scoreThreshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ranker"u8))
                {
                    ranker = new InternalRunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("score_threshold"u8))
                {
                    scoreThreshold = property.Value.GetSingle();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject(ranker, scoreThreshold, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject IPersistableModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRunStepDetailsToolCallsFileSearchRankingOptionsObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalRunStepDetailsToolCallsFileSearchRankingOptionsObject FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDetailsToolCallsFileSearchRankingOptionsObject(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
