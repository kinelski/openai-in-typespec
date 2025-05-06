namespace OpenAI.Responses;

[CodeGenType("ResponseContentPartDoneEvent")]
public partial class StreamingResponseContentPartDoneUpdate
{
    // CUSTOM: Apply generalized content type.
    [CodeGenMember("Part")]
    public ResponseContentPart Part { get; }
}