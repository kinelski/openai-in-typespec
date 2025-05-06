namespace OpenAI.Responses;

[CodeGenType("ResponseStatus")]
public enum ResponseStatus
{
    InProgress,
    Completed,
    Incomplete,
    Failed
}
