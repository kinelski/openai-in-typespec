using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Responses;

// CUSTOM:
// - Renamed.
[CodeGenType("ReasoningItem")]
public partial class ReasoningResponseItem
{
    // CUSTOM: Retain optionality of OpenAPI read-only property value
    [CodeGenMember("Status")]
    public ReasoningStatus? Status { get; }

    // CUSTOM: Convert simple text input into typed wire input
    public ReasoningResponseItem(IEnumerable<string> summaryTextParts)
        : this()
    {
        Argument.AssertNotNull(summaryTextParts, nameof(summaryTextParts));

        foreach (string summaryTextPart in summaryTextParts)
        {
            Summary.Add(new InternalReasoningItemSummaryText(summaryTextPart));
        }
    }

    // CUSTOM: Made internal for simplified public reprojection
    [CodeGenMember("Summary")]
    internal IList<InternalReasoningItemSummaryText> Summary { get; }

    public IReadOnlyList<string> SummaryTextParts
        => Summary?
            .Select(summaryElement => summaryElement as InternalReasoningItemSummaryText)?
            .Select(summaryTextElement => summaryTextElement.Text)?
            .ToList()
        ?? [];
}
