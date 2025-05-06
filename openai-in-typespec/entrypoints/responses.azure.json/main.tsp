import "@typespec/openapi3";
import "@typespec/openapi";

// Import order matters. Somehow, importing the server decorated namespace afterwards,
// will cause the the `description` field to be missing in the generated OpenAPI spec.
import "../../typespec.azure/servers/rest.tsp";
import "../../typespec.azure/responses";
import "../../typespec/specialized-types";
import "../responses.azure/visibility.tsp";
