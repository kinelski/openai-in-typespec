using System;
using System.Collections.Generic;

namespace OpenAI.Responses;

[CodeGenType("FileSearchToolCallResult")]
public partial class FileSearchCallResult
{
    // CUSTOM: Use a plain dictionary.
    [CodeGenMember("Attributes")]
    public IReadOnlyDictionary<string, BinaryData> Attributes { get; }
}