// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionRequestMessageContentPartFileFile
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalChatCompletionRequestMessageContentPartFileFile()
        {
        }

        internal InternalChatCompletionRequestMessageContentPartFileFile(string filename, string fileId, string fileData, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Filename = filename;
            FileId = fileId;
            FileData = fileData;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Filename { get; set; }

        public string FileId { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
