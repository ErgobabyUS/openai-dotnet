// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    public partial class StreamingResponseErrorUpdate : StreamingResponseUpdate
    {
        internal StreamingResponseErrorUpdate(string message, string code, string @param) : base(InternalResponsesResponseStreamEventType.Error)
        {
            Message = message;
            Code = code;
            Param = @param;
        }

        internal StreamingResponseErrorUpdate(InternalResponsesResponseStreamEventType @type, IDictionary<string, BinaryData> additionalBinaryDataProperties, string message, string code, string @param) : base(@type, additionalBinaryDataProperties)
        {
            Message = message;
            Code = code;
            Param = @param;
        }

        public string Message { get; }

        public string Code { get; }

        public string Param { get; }
    }
}
