namespace OpenAI.Responses;

// CUSTOM:
// - Renamed.
[CodeGenType("ItemReference")]
[CodeGenVisibility(nameof(ReferenceResponseItem), CodeGenVisibility.Internal)]
public partial class ReferenceResponseItem
{
    public ReferenceResponseItem(string id)
        : this(InternalItemType.ItemReference, id, null)
    { }
}
