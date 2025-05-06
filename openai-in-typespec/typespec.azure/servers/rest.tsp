import "@typespec/http";
import "@typespec/versioning";

import "../versions.tsp";

using TypeSpec.Http;
using TypeSpec.Versioning;

@service({
  title: "Azure OpenAI Service",
  termsOfService: "https://openai.com/policies/terms-of-use",
  contact: {
    name: "OpenAI Support",
    url: "https://help.openai.com",
  },
  license: {
    name: "MIT",
    url: "https://github.com/openai/openai-openapi/blob/master/LICENSE",
  },
})
@server(
  "{endpoint}/openai",
  "Azure OpenAI APIs for completions and search",
  {
    @doc("""
      Supported Cognitive Services endpoints (protocol and hostname, for example:
      https://westus.api.cognitive.microsoft.com).
      """)
    endpoint: string,
  }
)
@useAuth(
  ApiKeyAuth<ApiKeyLocation.header, "api-key"> | OAuth2Auth<[
    {
      type: OAuth2FlowType.implicit,
      authorizationUrl: "https://login.microsoftonline.com/common/oauth2/v2.0/authorize",
      scopes: ["https://cognitiveservices.azure.com/.default"],
    }
  ]>
)
@versioned(AzureOpenAI.AzureOpenAIServiceApiVersion)
namespace AzureOpenAI;
