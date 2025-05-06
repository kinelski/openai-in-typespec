import "@typespec/openapi3";
import "@typespec/openapi";

// Import order matters. Somehow, importing the server decorated namespace afterwards,
// will cause the the `description` field to be missing in the generated OpenAPI spec.
import "../../typespec/servers/rest.tsp";
import "../../typespec/responses";
import "../../typespec/specialized-types";

// To generate OpenAPI v3:
// run from the root of the TSP project: (openai-in-typespec folder)
// tsp compile entrypoints/responses

// To emit Java:
// from root of the TSP project run:
// tsp compile entrypoints/realtime --emit=@azure-tools/typespec-java
