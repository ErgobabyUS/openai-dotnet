// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    public partial class VectorStoreExpirationPolicy
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal VectorStoreExpirationPolicy(int days, VectorStoreExpirationAnchor anchor, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Days = days;
            Anchor = anchor;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public int Days { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
