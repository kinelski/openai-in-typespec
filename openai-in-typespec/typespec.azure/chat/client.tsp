import "@azure-tools/typespec-client-generator-core";
import "./models.oyd.auth.tsp";
import "./models.oyd.vectorization.tsp";
import "./models.request.tsp";
import "./models.response.tsp";

using Azure.ClientGenerator.Core;
using AzureOpenAI;

@@access(AzureChatMessageContext, Access.public);
@@usage(AzureChatMessageContext, Usage.output);

//
@@access(AzureChatDataSource, Access.public);
@@usage(AzureChatDataSource, Usage.input);

@@access(AzureCosmosDBChatDataSource, Access.public);
@@usage(AzureCosmosDBChatDataSource, Usage.input);

@@access(AzureSearchChatDataSource, Access.public);
@@usage(AzureSearchChatDataSource, Usage.input);

@@access(ElasticsearchChatDataSource, Access.public);
@@usage(ElasticsearchChatDataSource, Usage.input);

@@access(PineconeChatDataSource, Access.public);
@@usage(PineconeChatDataSource, Usage.input);

//
@@access(AzureChatDataSourceVectorizationSource, Access.public);
@@usage(AzureChatDataSourceVectorizationSource, Usage.output);

@@access(AzureChatDataSourceEndpointVectorizationSource, Access.public);
@@usage(AzureChatDataSourceEndpointVectorizationSource, Usage.output);

@@access(AzureChatDataSourceDeploymentNameVectorizationSource, Access.public);
@@usage(AzureChatDataSourceDeploymentNameVectorizationSource, Usage.output);

@@access(AzureChatDataSourceModelIdVectorizationSource, Access.public);
@@usage(AzureChatDataSourceModelIdVectorizationSource, Usage.output);

// Documentation overrides for properties where there is a mismatch in details or reference links

@@doc(AzureCreateChatCompletionRequest.messages,
  """
    A list of messages comprising the conversation so far. Depending on the
    model you use, different message types (modalities) are supported,
    like text, images, and audio.
    """
);

@@doc(AzureCreateChatCompletionRequest.web_search_options,
  """
    This tool searches the web for relevant results to use in a response.
    """
);

@@doc(AzureCreateChatCompletionRequest.store,
  """
    Whether or not to store the output of this chat completion request for
    use in model distillation or evals products.
    """
);

@@doc(AzureCreateChatCompletionRequest.max_tokens,
  """
    The maximum number of tokens that can be generated in the chat completion.
    This value can be used to control costs for text generated via API.
    
    This value is now deprecated in favor of `max_completion_tokens`, and is
    not compatible with o1 series models.
    """
);

@@doc(AzureCreateChatCompletionRequest.max_completion_tokens,
  """
    An upper bound for the number of tokens that can be generated for a
    completion, including visible output tokens and reasoning tokens.
    """
);

@@doc(AzureCreateChatCompletionRequest.prediction,
  """
    Configuration for a predicted output, which can greatly improve
    response times when large parts of the model response are known
    ahead of time. This is most common when you are regenerating a
    file with only minor changes to most of the content.
    """
);

@@doc(AzureCreateChatCompletionRequest.audio,
  """
    Parameters for audio output. Required when audio output is requested with
    `modalities: ["audio"]`.
    """
);

@@doc(AzureCreateChatCompletionRequest.stream,
  """
    If set to true, the model response data will be streamed to the client
    as it is generated using server-sent events.
    """
);

@@doc(AzureCreateChatCompletionRequest.response_format,
  """
    An object specifying the format that the model must output.
    
    Setting to `{ "type": "json_schema", "json_schema": {...} }` enables
    Structured Outputs which ensures the model will match your supplied JSON
    schema.
    
    Setting to `{ "type": "json_object" }` enables JSON mode, which ensures
    the message the model generates is valid JSON.
    
    **Important:** when using JSON mode, you **must** also instruct the model
    to produce JSON yourself via a system or user message. Without this, the
    model may generate an unending stream of whitespace until the generation
    reaches the token limit, resulting in a long-running and seemingly "stuck"
    request. Also note that the message content may be partially cut off if
    `finish_reason="length"`, which indicates the generation exceeded
    `max_tokens` or the conversation exceeded the max context length.
    """
);

@@doc(AzureCreateChatCompletionRequest.user,
  """
    A unique identifier representing your end-user, which can help OpenAI to
    monitor and detect abuse.
    """
);

@@doc(OpenAI.ChatCompletionModalities,
  """
    Output types that you would like the model to generate for this request.
    Most models are capable of generating text, which is the default:
    
    `["text"]`
    
    The `gpt-4o-audio-preview` model can also be used to generate audio. To
    request that this model generate both text and audio responses, you can
    use:
    
    `["text", "audio"]`
    """
);

@@doc(OpenAI.ChatCompletionFunctions.parameters,
  """
    The parameters the functions accepts, described as a JSON Schema object.
    See the [JSON Schema reference](https://json-schema.org/understanding-json-schema/)
    for documentation about the format.
    
    Omitting `parameters` defines a function with an empty parameter list.
    """
);

@@doc(OpenAI.ChatCompletionRequestAssistantMessage.audio,
  """
    Data about a previous audio response from the model.
    """
);

@@doc(OpenAI.ChatCompletionRequestMessageContentPartAudio, "");
@@doc(OpenAI.ChatCompletionRequestMessageContentPartImage, "");
@@doc(OpenAI.ChatCompletionRequestMessageContentPartText, "");

@@doc(OpenAI.ChatCompletionResponseMessage,
  """
    If the audio output modality is requested, this object contains data
    about the audio response from the model.
    """
);
