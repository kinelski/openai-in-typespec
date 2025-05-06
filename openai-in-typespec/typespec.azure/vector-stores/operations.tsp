import "@typespec/http";
import "@typespec/openapi";
import "@typespec/versioning";
import "../common/custom.tsp";
import "./models.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;
using TypeSpec.Versioning;

namespace AzureOpenAI;

@route("vector_stores")
interface AzureVectorStores {
  @route("{vector_store_id}/files/{file_id}")
  @post
  @operationId("updateVectorStoreFileAttributes")
  @tag("VectorStores")
  @added(AzureOpenAIServiceApiVersion.v2025_03_01_preview)
  updateVectorStoreFileAttributes(
    ...ApiVersionQueryParameter,
    @path vector_store_id: string,
    @path file_id: string,
    @body request: OpenAI.UpdateVectorStoreFileAttributesRequest,
  ): OpenAI.VectorStoreFileObject;
}
