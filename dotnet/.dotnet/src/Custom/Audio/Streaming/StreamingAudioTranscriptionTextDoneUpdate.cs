using System.Collections.Generic;

namespace OpenAI.Audio;

[CodeGenType("TranscriptTextDoneEvent")]
public partial class StreamingAudioTranscriptionTextDoneUpdate
{
    // CUSTOM: Rename; make readonly; apply shared audio logprobs type
    [CodeGenMember("Logprobs")]
    public IReadOnlyList<AudioTokenLogProbabilityDetails> TranscriptionTokenLogProbabilities { get; }
}