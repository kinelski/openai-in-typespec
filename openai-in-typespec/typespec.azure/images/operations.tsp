import "@typespec/http";
import "@typespec/openapi";

import "../common";
import "../common/custom.tsp";
import "./models.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;
using OpenAI;

namespace AzureOpenAI;

@route("/deployments/{deployment_id}/images")
interface AzureImages {
  @route("/generations")
  @post
  @operationId("ImageGenerations_Create")
  @tag("Images")
  createImage(
    ...DeploymentNamePathParameter,
    ...ApiVersionQueryParameter,
    @body image: CreateImageRequest,
  ): ImagesResponse | AzureOpenAIDalleErrorResponse;
}
