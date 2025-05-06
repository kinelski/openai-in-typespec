import "@typespec/rest";
import "@typespec/http";
import "@azure-tools/typespec-client-generator-core";

using TypeSpec.Http;
using TypeSpec.Rest;
using Azure.ClientGenerator.Core;

namespace AzureOpenAI;

@doc("A specific deployment")
@TypeSpec.Rest.resource("deployments")
model Deployment {
  @visibility("read")
  @doc("Specifies either the model deployment name (when using Azure OpenAI) or model name (when using non-Azure OpenAI) to use for this request.")
  @clientName("deploymentOrModelName", "java")
  @key
  @path("deployment-id")
  deploymentId: string;
}

alias DeploymentNamePathParameter = {
  /** Deployment ID of the model to use with this operation. */
  @path deployment_id: string;
};

alias ApiVersionQueryParameter = {
  /** The Azure OpenAI Service API version to use for this operation. */
  @query(#{ name: "api-version", explode: true })
  apiVersion: AzureOpenAIServiceApiVersion;
};
