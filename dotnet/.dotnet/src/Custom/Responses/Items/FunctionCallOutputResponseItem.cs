namespace OpenAI.Responses;

[CodeGenType("FunctionToolCallOutput")]
public partial class FunctionCallOutputResponseItem
{
    // CUSTOM: Renamed.
    [CodeGenMember("Output")]
    public string FunctionOutput { get; set; }

    // CUSTOM: Retain optionality of OpenAPI read-only property value
    [CodeGenMember("Status")]
    public FunctionCallOutputStatus? Status { get; }
}
