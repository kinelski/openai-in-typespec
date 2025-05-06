namespace OpenAI.Responses;

// CUSTOM:
// - Renamed.
[CodeGenType("WebSearchToolCall")]
public partial class WebSearchCallResponseItem
{
    // CUSTOM: Retain optionality of OpenAPI read-only property value
    [CodeGenMember("Status")]
    public WebSearchCallStatus? Status { get; }
}
