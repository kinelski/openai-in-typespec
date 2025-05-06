import "@azure-tools/typespec-azure-core";
import "@typespec/http";
import "@typespec/openapi";
import "@typespec/rest";
import "@typespec/versioning";

import "./models.transcription.tsp";
import "./common.tsp";

using TypeSpec.Rest;
using TypeSpec.Http;
using TypeSpec.OpenAPI;
using TypeSpec.Versioning;

using Azure.Core;

@versioned(AzureOpenAIServiceApiVersion)
namespace AzureOpenAI;

@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
@route("/deployments/{deployment_id}/audio/transcriptions")
interface AzureAudioTranscription {
  @post
  @summary("Transcribes audio into the input language.")
  @tag("Audio")
  Transcriptions_Create(
    ...DeploymentNamePathParameter,
    ...ApiVersionQueryParameter,
    @header contentType: "multipart/form-data",
    @body request: AzureCreateTranscriptionRequest,
  ): {
    @header contentType: "application/json";
    @body response: AzureAudioTranscriptionResponse;
  } | {
    @header contentType: "text/plain";
    @body response: string;
  };
}
