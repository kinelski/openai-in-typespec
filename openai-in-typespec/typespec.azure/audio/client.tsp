import "@azure-tools/typespec-client-generator-core";
import "./models.speech.tsp";

using Azure.ClientGenerator.Core;
using AzureOpenAI;

// Documentation overrides for properties where there is a mismatch in details or reference links

@@doc(AzureCreateSpeechRequest.voice,
  """
    The voice to use when generating the audio. Supported voices are `alloy`,
    `ash`, `coral`, `echo`, `fable`, `onyx`, `nova`, `sage` and `shimmer`.
    """
);

@@doc(AzureCreateTranscriptionRequest.prompt,
  """
    An optional text to guide the model's style or continue a previous audio segment.
    The prompt should match the audio language.
    """
);

@@doc(AzureCreateTranslationRequest.prompt,
  """
    An optional text to guide the model's style or continue a previous audio segment.
    The prompt should be in English.
    """
);
