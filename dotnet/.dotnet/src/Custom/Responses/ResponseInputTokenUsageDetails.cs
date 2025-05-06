namespace OpenAI.Responses;

[CodeGenType("ResponseUsageInputTokensDetails")]
public partial class ResponseInputTokenUsageDetails
{
    // CUSTOM: Renamed.
    [CodeGenMember("CachedTokens")]
    public int CachedTokenCount { get; }

}