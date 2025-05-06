using System;

namespace OpenAI.Audio;

[CodeGenType("DotNetAudioLogProbsProperties")]
public partial class AudioTokenLogProbabilityDetails
{
    // CUSTOM: Renamed.
    [CodeGenMember("Logprob")]
    public float LogProbability { get; }

    // CUSTOM: Renamed, type changed to ReadOnlyMemory<byte>
    [CodeGenMember("Bytes")]
    public ReadOnlyMemory<byte> Utf8Bytes { get; }
}