import "@azure-tools/typespec-azure-core";
import "@typespec/http";
import "@typespec/openapi";

import "../common/custom.tsp";
import "../common/models.errors.tsp";
import "./models.response.tsp";
import "./models.request.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;
using TypeSpec.Rest;

using Azure.Core;

namespace AzureOpenAI;

@route("/deployments/{deployment_id}/completions")
interface AzureCompletions {
  @post
  @operationId("Completions_Create")
  @summary("Creates a completion for the provided prompt, parameters and chosen model.")
  @extension(
    "x-ms-examples",
    {
      `Create a chat completion`: {
        $ref: "./examples/completions.yaml",
      },
    }
  )
  @tag("Completions")
  Completions_Create(
    ...DeploymentNamePathParameter,
    ...ApiVersionQueryParameter,
    @body request: AzureCreateCompletionRequest,
  ): {
    @statusCode _: 200;
    @header("apim-request-id") requestId: string;
    @body response: AzureCreateCompletionResponse;
  } | {
    @header("apim-request-id") requestId: string;
    @body defaultError: AzureOpenAICompletionErrorResponse;
  };
}
