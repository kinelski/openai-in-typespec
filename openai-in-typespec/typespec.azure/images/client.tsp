import "@azure-tools/typespec-client-generator-core";
import "./models.tsp";

using Azure.ClientGenerator.Core;
using AzureOpenAI;

@@access(AzureImage, Access.public);
@@usage(AzureImage, Usage.output);

// Documentation overrides for properties where there is a mismatch in details or reference links

@@doc(OpenAI.CreateImageRequest.user,
  """
    A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse.
    """
);
