namespace OpenAI.Responses;

// CUSTOM:
// - Renamed.
[CodeGenType("FileSearchToolCall")]
public partial class FileSearchCallResponseItem
{
    // CUSTOM: Retain optionality of OpenAPI read-only property value
    [CodeGenMember("Status")]
    public FileSearchCallStatus? Status { get; }
}