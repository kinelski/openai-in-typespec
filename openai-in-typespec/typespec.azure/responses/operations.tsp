import "@typespec/http";
import "@typespec/openapi";
import "@typespec/versioning";

import "../versions.tsp";
import "../../typespec/responses";

using TypeSpec.Http;
using TypeSpec.Versioning;

namespace AzureOpenAI;

@route("/responses")
@added(AzureOpenAIServiceApiVersion.v2025_03_01_preview)
interface AzureResponses extends OpenAI.Responses {}
