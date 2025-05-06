namespace OpenAI.Responses;

// CUSTOM: Renamed.
[CodeGenType("WebSearchToolCallStatus")]
public enum WebSearchCallStatus
{
    InProgress,
    Searching,
    Completed,
    Failed
}