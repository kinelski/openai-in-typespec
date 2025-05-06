using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Responses;

[CodeGenType("ComputerToolCallOutput")]
[Experimental("OPENAICUA001")]
public partial class ComputerCallOutputResponseItem
{
    // CUSTOM: Retain optionality of OpenAPI read-only property value
    [CodeGenMember("Status")]
    public ComputerCallOutputStatus? Status { get; }
}
