namespace OpenAI.Responses;

[CodeGenType("Reasoning")]
[CodeGenVisibility(nameof(ResponseReasoningOptions), CodeGenVisibility.Public)]
public partial class ResponseReasoningOptions
{
    // CUSTOM: Renamed.
    [CodeGenMember("Effort")]
    public ResponseReasoningEffortLevel? ReasoningEffortLevel { get; set; }

    // CUSTOM: Renamed.
    [CodeGenMember("GenerateSummary")]
    public ResponseReasoningSummaryVerbosity? ReasoningSummaryVerbosity { get; set; }
}