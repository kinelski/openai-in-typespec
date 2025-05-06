namespace OpenAI.Chat;

/// <summary>
/// Represents the possibles of underlying data for a chat message's <c>content</c> property.
/// </summary>
[CodeGenType("ChatCompletionRequestMessageContentPartType")]
public enum ChatMessageContentPartKind
{
    [CodeGenMember("Text")]
    Text,

    [CodeGenMember("Refusal")]
    Refusal,

    [CodeGenMember("ImageUrl")]
    Image,

    [CodeGenMember("InputAudio")]
    InputAudio,

    [CodeGenMember("File")]
    File,
}