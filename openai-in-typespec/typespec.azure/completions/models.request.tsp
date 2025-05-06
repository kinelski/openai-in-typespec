import "@typespec/rest";
import "@typespec/http";
import "@typespec/versioning";
import "@azure-tools/typespec-client-generator-core";

using TypeSpec.Rest;
using TypeSpec.Http;
using TypeSpec.Versioning;
using Azure.ClientGenerator.Core;

namespace AzureOpenAI;

@withoutOmittedProperties("model")
@withoutOmittedProperties("prompt")
model CreateCompletionRequestCommonBase is OpenAI.CreateCompletionRequest;

model AzureCreateCompletionRequest {
  /**
   * The prompt(s) to generate completions for, encoded as a string, array of strings, array of tokens, or array of token arrays.
   * Note that <|endoftext|> is the document separator that the model sees during training, so if a prompt is not specified the model will generate as if from the beginning of a new document.
   */
  @TypeSpec.OpenAPI.oneOf
  prompt?: string | string[] | null = "<|endoftext|>";

  ...CreateCompletionRequestCommonBase;
}
