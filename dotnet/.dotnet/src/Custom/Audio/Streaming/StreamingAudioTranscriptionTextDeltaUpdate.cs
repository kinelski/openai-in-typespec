using System.Collections.Generic;

namespace OpenAI.Audio;

[CodeGenType("TranscriptTextDeltaEvent")]
public partial class StreamingAudioTranscriptionTextDeltaUpdate
{
    // CUSTOM: Rename; make readonly
    [CodeGenMember("Logprobs")]
    public IReadOnlyList<AudioTokenLogProbabilityDetails> TranscriptionTokenLogProbabilities { get; }
}