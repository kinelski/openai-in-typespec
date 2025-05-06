namespace OpenAI.Responses;

// CUSTOM: Renamed.
[CodeGenType("FileSearchToolCallStatus")]
public enum FileSearchCallStatus
{
    InProgress,
    Searching,
    Completed,
    Incomplete,
    Failed
}
