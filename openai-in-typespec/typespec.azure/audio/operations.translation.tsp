import "@azure-tools/typespec-azure-core";
import "@typespec/rest";
import "@typespec/http";
import "@typespec/openapi";
import "@typespec/versioning";

import "./models.translation.tsp";
import "./common.tsp";

using TypeSpec.Rest;
using TypeSpec.Http;
using TypeSpec.OpenAPI;
using TypeSpec.Versioning;

using Azure.Core;

@versioned(AzureOpenAIServiceApiVersion)
namespace AzureOpenAI;

@added(AzureOpenAIServiceApiVersion.v2024_02_15_preview)
@route("/deployments/{deployment_id}/audio/translations")
interface AzureAudioTranslation {
  @post
  @operationId("Translations_Create")
  @summary("Gets English language transcribed text and associated metadata from provided spoken audio data.")
  @tag("Audio")
  Translations_Create(
    ...DeploymentNamePathParameter,
    ...ApiVersionQueryParameter,
    @header contentType: "multipart/form-data",
    @body request: AzureCreateTranslationRequest,
  ): {
    @header contentType: "application/json";
    @body response: AzureAudioTranslationResponse;
  } | {
    @header contentType: "text/plain";
    @body response: string;
  };
}
