import "@azure-tools/typespec-client-generator-core";
import "./custom.tsp";
import "./models.tsp";

using Azure.ClientGenerator.Core;
using OpenAI;

@@visibility(ListVectorStoresResponse.data, "read");
@@visibility(ListVectorStoreFilesResponse.data, "read");

@@visibility(VectorStoreObject.metadata, "read");
