import "@azure-tools/typespec-azure-core";
import "@typespec/http";
import "@typespec/openapi";
import "@typespec/rest";
import "@typespec/versioning";

import "./models.speech.tsp";
import "../common/custom.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;
using TypeSpec.Rest;
using TypeSpec.Versioning;

using Azure.Core;

namespace AzureOpenAI;

@route("/deployments/{deployment_id}/audio/speech")
interface AzureAudioSpeech {
  @post
  @operationId("Speech_Create")
  @summary("Generates text-to-speech audio from the input text.")
  @tag("Audio")
  Speech_Create(
    ...DeploymentNamePathParameter,
    ...ApiVersionQueryParameter,
    @header contentType: "multipart/form-data",
    @body request: AzureCreateSpeechRequest,
  ): {
    @statusCode _: 200;

    /** The content type of the response. Always application/octet-stream for audio/speech responses. */
    @header contentType: "application/octet-stream";

    @body response: bytes;
  };
}
