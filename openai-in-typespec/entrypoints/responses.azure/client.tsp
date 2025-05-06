import "@azure-tools/typespec-client-generator-core";

import "./main.tsp";

using Azure.ClientGenerator.Core;
using TypeSpec.Http;

@client({
  name: "ResponsesClient",
  service: AzureOpenAI,
})
interface ResponsesClient {
  @route("/responses")
  createResponse is AzureOpenAI.AzureResponses.createResponse;

  @route("/responses/{response_id}")
  getResponse is AzureOpenAI.AzureResponses.getResponse;

  @route("/responses/{response_id}")
  deleteResponse is AzureOpenAI.AzureResponses.deleteResponse;

  @route("/responses/{response_id}/input_items")
  listInputItems is AzureOpenAI.AzureResponses.listInputItems;
}
