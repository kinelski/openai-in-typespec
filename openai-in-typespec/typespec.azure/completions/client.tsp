import "@azure-tools/typespec-client-generator-core";
import "./models.request.tsp";
import "./models.response.tsp";

using Azure.ClientGenerator.Core;
using AzureOpenAI;

// Documentation overrides for properties where there is a mismatch in details or reference links

@@doc(AzureCreateCompletionRequest.frequency_penalty,
  """
    Number between -2.0 and 2.0. Positive values penalize new tokens based on
    their existing frequency in the text so far, decreasing the model's
    likelihood to repeat the same line verbatim.
    """
);

@@doc(AzureCreateCompletionRequest.presence_penalty,
  """
    Number between -2.0 and 2.0. Positive values penalize new tokens based on
    whether they appear in the text so far, increasing the model's likelihood
    to talk about new topics.
    """
);

@@doc(AzureCreateCompletionRequest.user,
  """
    A unique identifier representing your end-user, which can help OpenAI
    to monitor and detect abuse.
    """
);
