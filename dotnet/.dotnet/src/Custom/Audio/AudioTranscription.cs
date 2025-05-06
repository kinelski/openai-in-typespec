using System;
using System.Collections.Generic;

namespace OpenAI.Audio;

[CodeGenType("DotNetCombinedJsonTranscriptionResponse")]
public partial class AudioTranscription
{
    // CUSTOM: Made private. This property does not add value in the context of a strongly-typed class.
    private InternalCreateTranscriptionResponseVerboseJsonTask Task { get; } = InternalCreateTranscriptionResponseVerboseJsonTask.Transcribe;

    // CUSTOM: Made nullable because this is an optional property.
    /// <summary> The duration of the input audio. </summary>
    public TimeSpan? Duration { get; }

    // CUSTOM: Reuse common logprob type, make readonly
    [CodeGenMember("Logprobs")]
    public IReadOnlyList<AudioTokenLogProbabilityDetails> TranscriptionTokenLogProbabilities { get; }
}