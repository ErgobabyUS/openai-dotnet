using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.VectorStores;

/// <summary>
/// Represents the the configuration that controls when a vector store will be automatically deleted.
/// </summary>
[Experimental("OPENAI001")]
[CodeGenType("VectorStoreExpirationAfter")]
[CodeGenSuppress(nameof(VectorStoreExpirationPolicy), typeof(int))]
public partial class VectorStoreExpirationPolicy
{
    [CodeGenMember("Anchor")]
    public VectorStoreExpirationAnchor Anchor { get; set; } = VectorStoreExpirationAnchor.LastActiveAt;

    public VectorStoreExpirationPolicy(VectorStoreExpirationAnchor anchor, int days)
        : this(days, anchor, null)
    {
    }
}
