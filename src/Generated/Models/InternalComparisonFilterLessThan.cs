// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalComparisonFilterLessThan : InternalComparisonFilter
    {
        public InternalComparisonFilterLessThan(string key, BinaryData value) : base(InternalComparisonFilterType.Lt, key, value)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

        }

        internal InternalComparisonFilterLessThan(InternalComparisonFilterType @type, string key, BinaryData value, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(@type, key, value, additionalBinaryDataProperties)
        {
        }
    }
}
