import "@typespec/http";
import "@typespec/openapi";

import "../common/custom.tsp";
import "./custom.tsp";
import "./models.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;

namespace OpenAI;

@route("/responses")
interface Responses {
  /**
   * Creates a model response.
   */
  @operationId("createResponse")
  @post
  createResponse(
    ...AcceptJsonOrEventStreamHeader,
    @body requestBody: CreateResponse,
  ): ResponseStreamEvent[] | Response | ResponseErrorResponse;

  /**
   * Retrieves a model response with the given ID.
   *
   * @param response_id The ID of the response to retrieve.
   * @param include Specifies additional output data to include in the model response.
   */
  @operationId("getResponse")
  @get
  @route("/{response_id}")
  getResponse(
    @example("resp_677efb5139a88190b512bc3fef8e535d")
    response_id: string,

    @query(#{ name: "include[]", explode: true })
    includables?: Includable[] = #[],
  ): Response | ResponseErrorResponse;

  /**
   * Returns a list of input items for a given response.
   *
   * @param response_id The ID of the response to retrieve.
   */
  @operationId("listInputItems")
  @get
  @route("/{response_id}/input_items")
  listInputItems(
    @example("resp_677efb5139a88190b512bc3fef8e535d")
    response_id: string,

    ...CommonPageQueryParameters,
  ): ResponseItemList | ResponseErrorResponse;

  /**
   * Deletes a response by ID.
   */
  @operationId("deleteResponse")
  @delete
  @route("/{response_id}")
  deleteResponse(
    @path
    @example("resp_677efb5139a88190b512bc3fef8e535d")
    response_id: string,
  ): {
    object: "response.deleted";
    id: string;
    deleted: true;
  } | ResponseErrorResponse;
}
