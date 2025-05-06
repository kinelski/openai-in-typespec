import "../../typespec/completions/models.tsp";
import "../common/models.rai.tsp";

using OpenAI;

using TypeSpec.Versioning;
namespace AzureOpenAI;

model CompletionChoice {
  /**
   * The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
   * `length` if the maximum number of tokens specified in the request was reached,
   * or `content_filter` if content was omitted due to a flag from our content filters.
   */
  finish_reason: "stop" | "length" | "content_filter";

  index: int32;
  logprobs: {
    text_offset?: int32[];
    token_logprobs?: float32[];
    tokens?: string[];
    top_logprobs?: Record<float32>[];
  } | null;
  text: string;
  content_filter_results?: AzureContentFilterResultForChoice;
}

@withoutOmittedProperties("choices")
model CreateCompletionResponseCommonBase is OpenAI.CreateCompletionResponse;

/** Represents a completion response from the API. Note: both the streamed and non-streamed response objects share the same shape (unlike the chat endpoint). */
model AzureCreateCompletionResponse {
  ...CreateCompletionResponseCommonBase;

  /** The list of completion choices the model generated for the input prompt. */
  choices: CompletionChoice[];

  prompt_filter_results?: AzureContentFilterResultForPrompt[];
}
