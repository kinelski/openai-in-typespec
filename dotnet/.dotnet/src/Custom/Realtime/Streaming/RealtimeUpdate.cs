using System;
using System.ClientModel.Primitives;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Realtime;

[Experimental("OPENAI002")]
[CodeGenType("RealtimeServerEvent")]
[CodeGenVisibility(nameof(Kind), CodeGenVisibility.Public)]
public partial class RealtimeUpdate
{
    public BinaryData GetRawContent() => ModelReaderWriter.Write(this);
}