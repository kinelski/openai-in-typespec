namespace OpenAI.Responses;

[CodeGenType("CreateResponseText")]
public partial class ResponseTextOptions
{
    // CUSTOM: Renamed.
    [CodeGenMember("Format")]
    public ResponseTextFormat TextFormat { get; set; }
}