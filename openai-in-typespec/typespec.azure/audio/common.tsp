import "@typespec/versioning";
import "@typespec/http";
import "../versions.tsp";

using TypeSpec.Http;
using TypeSpec.Versioning;

namespace AzureOpenAI;

/**
 * Defines the possible descriptors for available audio operation responses.
 */
@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
union AudioTaskLabel {
  string,

  /**
   * Accompanying response data resulted from an audio transcription task.
   */
  transcribe: "transcribe",

  /**
   * Accompanying response data resulted from an audio translation task.
   */
  translate: "translate",
}

alias AudioTextResponse = {
  /**
   * Representation of the response data of audio text.
   */
  @bodyRoot
  body: string;
};

model AudioSegment {
  /**
   * The 0-based index of this segment within a translation.
   */
  id: int32;

  /**
   * The time at which this segment started relative to the beginning of the translated audio.
   */
  @encode("seconds", float32)
  start: duration;

  /**
   * The time at which this segment ended relative to the beginning of the translated audio.
   */
  @encode("seconds", float32)
  end: duration;

  /**
   * The translated text that was part of this audio segment.
   */
  text: string;

  /**
   * The temperature score associated with this audio segment.
   */
  temperature: float32;

  /**
   * The average log probability associated with this audio segment.
   */
  avg_logprob: float32;

  /**
   * The compression ratio of this audio segment.
   */
  compression_ratio: float32;

  /**
   * The probability of no speech detection within this audio segment.
   */
  no_speech_prob: float32;

  /**
   * The token IDs matching the translated text in this audio segment.
   */
  tokens: int32[];

  /**
   * The seek position associated with the processing of this audio segment.
   * Seek positions are expressed as hundredths of seconds.
   * The model may process several segments from a single seek position, so while the seek position will never represent
   * a later time than the segment's start, the segment's start may represent a significantly later time than the
   * segment's associated seek position.
   */
  seek: int32;
}
