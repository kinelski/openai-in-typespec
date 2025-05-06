import "@azure-tools/typespec-client-generator-core";
import "@typespec/http";

using Azure.ClientGenerator.Core;
using TypeSpec.Http;

namespace OpenAI;

// Here, we create scenario-specific copies of types for the .NET SDK.

@access(Access.public)
@usage(Usage.input | Usage.output)
@discriminator("type")
model DotNetChatResponseFormat {
  ...ResponseFormat;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetChatResponseFormatText extends DotNetChatResponseFormat {
  ...ResponseFormatText;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetChatResponseFormatJsonObject extends DotNetChatResponseFormat {
  ...ResponseFormatJsonObject;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetChatResponseFormatJsonSchema extends DotNetChatResponseFormat {
  type: "json_schema";
  json_schema: {
    description?: string;
    name: string;
    schema?: unknown;
    strict?: boolean | null = false;
  };
}

@access(Access.public)
@usage(Usage.input | Usage.output)
@discriminator("type")
model DotNetAssistantResponseFormat {
  ...ResponseFormat;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetAssistantResponseFormatText extends DotNetAssistantResponseFormat {
  ...ResponseFormatText;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetAssistantResponseFormatJsonObject
  extends DotNetAssistantResponseFormat {
  ...ResponseFormatJsonObject;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetAssistantResponseFormatJsonSchema
  extends DotNetAssistantResponseFormat {
  type: "json_schema";
  json_schema: {
    description?: string;
    name: string;
    schema?: unknown;
    strict?: boolean | null = false;
  };
}

@access(Access.public)
@usage(Usage.input | Usage.output)
union DotNetResponseReasoningEffortLevel {
  ReasoningEffort,
}

@access(Access.public)
@usage(Usage.input | Usage.output)
union DotNetResponseWebSearchContextSize {
  WebSearchContextSize,
}

// This artificial type facilitates the merged representation of input/output chunking strategy values.

@discriminator("type")
model DotNetCombinedChunkingStrategyParam {
  type: "auto" | "static" | "other";
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetCombinedAutoChunkingStrategyParam
  extends DotNetCombinedChunkingStrategyParam {
  ...AutoChunkingStrategyRequestParam;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetCombinedStaticChunkingStrategyParam
  extends DotNetCombinedChunkingStrategyParam {
  ...StaticChunkingStrategyResponseParam;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
model DotNetCombinedOtherChunkingStrategyParam
  extends DotNetCombinedChunkingStrategyParam {
  ...OtherChunkingStrategyResponseParam;
}

@access(Access.public)
@usage(Usage.output)
model DotNetCombinedJsonTranscriptionResponse {
  ...CreateTranscriptionResponseVerboseJson;
  logprobs?: LogProbProperties[];
}

@access(Access.public)
@usage(Usage.output)
model DotNetAudioLogProbsProperties {
  ...LogProbProperties;
}

@access(Access.public)
@usage(Usage.output)
model DotNetRealtimeLogProbsProperties {
  ...LogProbProperties;
}

@access(Access.public)
@usage(Usage.input | Usage.output)
union DotNetAudioVoiceIds {
  VoiceIdsShared,
}

@access(Access.public)
@usage(Usage.input | Usage.output)
union DotNetChatVoiceIds {
  VoiceIdsShared,
}

@access(Access.public)
@usage(Usage.input | Usage.output)
union DotNetRealtimeVoiceIds {
  VoiceIdsShared,
}
