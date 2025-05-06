import "@typespec/http";
import "@typespec/openapi";

import "../common/custom.tsp";
import "./models.request.tsp";
import "./models.response.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;

namespace AzureOpenAI;

@route("/deployments/{deployment_id}/chat")
interface AzureChat {
  @route("completions")
  @post
  @operationId("ChatCompletions_Create")
  @summary("Creates a completion for the chat message")
  @extension(
    "x-ms-examples",
    {
      `Create a chat completion`: {
        $ref: "./examples/chat_completions.yaml",
      },
    }
  )
  @tag("Chat")
  createChatCompletion(
    ...DeploymentNamePathParameter,
    ...ApiVersionQueryParameter,
    @body request: AzureCreateChatCompletionRequest,
  ): AzureCreateChatCompletionResponse | AzureChatCompletionStreamResponseDelta[] | AzureOpenAIChatErrorResponse;
}
