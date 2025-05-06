using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Responses;

// CUSTOM: Renamed.
[CodeGenType("ComputerToolCallOutputStatus")]
[Experimental("OPENAICUA001")]
public enum ComputerCallOutputStatus
{
    InProgress,
    Completed,
    Incomplete
}