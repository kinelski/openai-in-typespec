using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Responses;

// CUSTOM: Renamed.
[CodeGenType("ComputerToolCallStatus")]
[Experimental("OPENAICUA001")]
public enum ComputerCallStatus
{
    InProgress,
    Completed,
    Incomplete
}