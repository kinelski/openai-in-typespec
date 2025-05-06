// Import order matters. Somehow, importing the server decorated namespace afterwards,
// will cause the the `description` field to be missing in the generated OpenAPI spec.
import "../sdk.dotnet/specialized-types.tsp";
import "../sdk.dotnet/extra-types.tsp";
import "../../typespec.azure/servers/rest.tsp";
import "../../typespec.azure";
