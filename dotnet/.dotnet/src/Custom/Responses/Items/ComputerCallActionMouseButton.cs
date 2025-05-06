using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Responses;

[CodeGenType("ComputerActionClickButton")]
[Experimental("OPENAICUA001")]
public enum ComputerCallActionMouseButton
{
    Left,
    Right,
    Wheel,
    Back,
    Forward
}
