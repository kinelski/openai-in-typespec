namespace OpenAI.Responses;

[CodeGenType("WebSearchTool")]
internal partial class InternalWebSearchTool
{
    // CUSTOM: Apply use of a scenario-specific type copy.
    [CodeGenMember("SearchContetSize")]
    internal WebSearchContextSize? SearchContextSize { get; set; }
}