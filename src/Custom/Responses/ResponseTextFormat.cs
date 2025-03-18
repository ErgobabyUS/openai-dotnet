﻿using System;

namespace OpenAI.Responses;

[CodeGenType("ResponsesTextFormat")]
public partial class ResponseTextFormat
{
    // CUSTOM: Renamed to "Kind" and converted to public enum from internal extensible type.
    [CodeGenMember("Type")]
    internal InternalResponsesTextFormatType InternalType { get; set;  }
    public ResponseTextFormatKind Kind
    {
        get => InternalType.ToString().ToResponseTextFormatKind();
        set => InternalType = value.ToSerialString();
    }

    public static ResponseTextFormat CreateTextFormat() => new InternalResponsesTextFormatText();

    public static ResponseTextFormat CreateJsonObjectFormat() => new InternalResponsesTextFormatJsonObject();

    public static ResponseTextFormat CreateJsonSchemaFormat(string jsonSchemaFormatName, BinaryData jsonSchema, string jsonSchemaFormatDescription = null, bool? jsonSchemaIsStrict = null)
    {
        Argument.AssertNotNullOrEmpty(jsonSchemaFormatName, nameof(jsonSchemaFormatName));
        Argument.AssertNotNull(jsonSchema, nameof(jsonSchema));

         return new InternalResponsesTextFormatJsonSchema(
            InternalResponsesTextFormatType.JsonSchema,
            additionalBinaryDataProperties: null,
            jsonSchemaFormatName,
            jsonSchema,
            jsonSchemaFormatDescription,
            jsonSchemaIsStrict);
    }
}