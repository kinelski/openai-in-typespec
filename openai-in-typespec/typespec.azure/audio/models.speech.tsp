import "@typespec/versioning";
import "@typespec/http";
import "@azure-tools/typespec-client-generator-core";

import "../../typespec/audio/models.tsp";

using Azure.ClientGenerator.Core;
using TypeSpec.Versioning;
using TypeSpec.Http;

namespace AzureOpenAI;

/**
 * The available voices for text-to-speech.
 */
@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
union SpeechVoice {
  string,

  /**
   * The Alloy voice.
   */
  alloy: "alloy",

  /**
   * The Echo voice.
   */
  echo: "echo",

  /**
   * The Fable voice.
   */
  fable: "fable",

  /**
   * The Onyx voice.
   */
  onyx: "onyx",

  /**
   * The Nova voice.
   */
  nova: "nova",

  /**
   * The Shimmer voice.
   */
  shimmer: "shimmer",
}

/**
 * The supported audio output formats for text-to-speech.
 */
@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
@TypeSpec.OpenAPI.oneOf
union SpeechGenerationResponseFormat {
  string,

  /**
   * Use MP3 as the audio output format. MP3 is the default, general-purpose format.
   */
  mp3: "mp3",

  /**
   * Use Opus as the audio output format. Opus is optimized for internet streaming and low latency.
   */
  opus: "opus",

  /**
   * Use AAC as the audio output format. AAC is optimized for digital audio compression and is preferred by YouTube, Android, and iOS.
   */
  aac: "aac",

  /**
   * Use FLAC as the audio output format. FLAC is a fully lossless format optimized for maximum quality at the expense of size.
   */
  flac: "flac",

  /**
   * Use uncompressed WAV as the audio output format, suitable for low-latency applications to avoid decoding overhead.
   */
  @added(AzureOpenAIServiceApiVersion.v2024_04_01_preview)
  wav: "wav",

  /**
   * Use uncompressed PCM as the audio output format, which is similar to WAV but contains raw samples in 24kHz (16-bit signed, low-endian), without the header.
   */
  @added(AzureOpenAIServiceApiVersion.v2024_04_01_preview)
  pcm: "pcm",
}

@withoutOmittedProperties("response_format")
@withoutOmittedProperties("speed")
@withoutOmittedProperties("model")
model CreateSpeechRequestCommonBase is OpenAI.CreateSpeechRequest;

/**
 * A representation of the request options that control the behavior of a text-to-speech operation.
 */
@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
model AzureCreateSpeechRequest {
  ...CreateSpeechRequestCommonBase;

  /**
   * The audio output format for the spoken text. By default, the MP3 format will be used.
   */
  response_format?: SpeechGenerationResponseFormat;

  /**
   * The speed of speech for generated audio. Values are valid in the range from 0.25 to 4.0, with 1.0 the default and higher values corresponding to faster speech.
   */
  @minValue(0.25)
  @maxValue(4.0)
  speed?: float32 = 1.0;

  /**
   * The model to use for this text-to-speech request.
   */
  // Implementation note: developer-facing specification of deployment or model by clients should be controlled either
  // via an operation parameter or by this request body field -- but only one of those. This field should be hidden by
  // clients if operation parameters are used and populated into the request body on an as-needed basis.
  `model`?: string;
}

/**
 * A representation of a response for a text-to-speech operation.
 */
@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
model SpeechGenerationResponse {
  /**
   * The generated audio, generated in the requested audio output format.
   */
  @bodyRoot
  audio: bytes;
}
