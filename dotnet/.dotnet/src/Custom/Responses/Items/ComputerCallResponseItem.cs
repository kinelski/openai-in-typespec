using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace OpenAI.Responses;

// CUSTOM:
// - Renamed.
[CodeGenType("ComputerToolCall")]
[Experimental("OPENAICUA001")]
public partial class ComputerCallResponseItem
{
    // CUSTOM: Retain optionality of OpenAPI read-only property value
    [CodeGenMember("Status")]
    public ComputerCallStatus? Status { get; }
}
