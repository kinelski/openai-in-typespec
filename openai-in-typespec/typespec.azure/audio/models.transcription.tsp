import "@typespec/versioning";
import "@azure-tools/typespec-client-generator-core";

import "./common.tsp";
import "../../typespec/audio/models.tsp";

using TypeSpec.Http;
using TypeSpec.Versioning;
using Azure.ClientGenerator.Core;

namespace AzureOpenAI;

@withoutOmittedProperties("model")
model AzureCreateTranscriptionRequestCommonBase
  is OpenAI.CreateTranscriptionRequest;

/**
 * The configuration information for an audio transcription request.
 */
@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
model AzureCreateTranscriptionRequest {
  ...AzureCreateTranscriptionRequestCommonBase;

  /**
   * The optional filename or descriptive identifier to associate with with the audio data.
   */
  // Note: although this isn't explicitly part of the request schema per documentation, it is present via the encoded
  // content-disposition header for the binary section of the multipart/form-data content.
  filename?: string;

  /**
   * The model to use for this transcription request.
   */
  // Implementation note: developer-facing specification of deployment or model by clients should be controlled either
  // via an operation parameter or by this request body field -- but only one of those. This field should be hidden by
  // clients if operation parameters are used and populated into the request body on an as-needed basis.
  `model`?: string;
}

/**
 * Result information for an operation that transcribed spoken audio into written text.
 */
@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
model AzureAudioTranscriptionResponse {
  /**
   * The transcribed text for the provided audio data.
   */
  text: string;

  /**
   * The label that describes which operation type generated the accompanying response data.
   */
  task?: AudioTaskLabel;

  /**
   * The spoken language that was detected in the transcribed audio data.
   * This is expressed as a two-letter ISO-639-1 language code like 'en' or 'fr'.
   */
  language?: string;

  /**
   * The total duration of the audio processed to produce accompanying transcription information.
   */
  @encode("seconds", float32)
  duration?: duration;

  /**
   * A collection of information about the timing, probabilities, and other detail of each processed audio segment.
   */
  segments?: OpenAI.TranscriptionSegment[];

  /**
   * A collection of information about the timing of each processed word.
   */
  @added(AzureOpenAIServiceApiVersion.v2024_04_01_preview)
  words?: OpenAI.TranscriptionWord[];
}
