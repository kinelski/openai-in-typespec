import "@azure-tools/typespec-client-generator-core";

using Azure.ClientGenerator.Core;
using OpenAI;

// @@access(Responses.createResponse, Access.public);

// @@access(ResponsesStreamEvent, Access.public);
// @@usage(ResponsesStreamEvent, Usage.output);

@@access(ResponseStreamEvent, Access.public);
@@usage(ResponseStreamEvent, Usage.output);

@@access(ResponseCreatedEvent, Access.public);
@@usage(ResponseCreatedEvent, Usage.output);

@@access(ResponseCompletedEvent, Access.public);
@@usage(ResponseCompletedEvent, Usage.output);

@@access(ResponseOutputItemAddedEvent, Access.public);
@@usage(ResponseOutputItemAddedEvent, Usage.output);

@@access(ResponseTextDeltaEvent, Access.public);
@@usage(ResponseTextDeltaEvent, Usage.output);

@@access(ResponseFunctionCallArgumentsDeltaEvent, Access.public);
@@usage(ResponseFunctionCallArgumentsDeltaEvent, Usage.output);

@@access(ResponseFunctionCallArgumentsDoneEvent, Access.public);
@@usage(ResponseFunctionCallArgumentsDoneEvent, Usage.output);

@@access(ResponseFileSearchCallInProgressEvent, Access.public);
@@usage(ResponseFileSearchCallInProgressEvent, Usage.output);

@@access(ResponseFileSearchCallSearchingEvent, Access.public);
@@usage(ResponseFileSearchCallSearchingEvent, Usage.output);

@@access(ResponseFileSearchCallCompletedEvent, Access.public);
@@usage(ResponseFileSearchCallCompletedEvent, Usage.output);

// @@access(ResponseCodeInterpreterCallInProgressEvent,
//   Access.public
// );
// @@usage(ResponseCodeInterpreterCallInProgressEvent,
//   Usage.output
// );

// @@access(ResponseCodeInterpreterCallCodeDeltaEvent,
//   Access.public
// );
// @@usage(ResponseCodeInterpreterCallCodeDeltaEvent,
//   Usage.output
// );

// @@access(ResponseCodeInterpreterCallCodeDoneEvent,
//   Access.public
// );
// @@usage(ResponseCodeInterpreterCallCodeDoneEvent,
//   Usage.output
// );

// @@access(ResponseCodeInterpreterCallCompletedEvent,
//   Access.public
// );
// @@usage(ResponseCodeInterpreterCallCompletedEvent,
//   Usage.output
// );

@@access(ResponseRefusalDeltaEvent, Access.public);
@@usage(ResponseRefusalDeltaEvent, Usage.output);

@@access(ResponseRefusalDoneEvent, Access.public);
@@usage(ResponseRefusalDoneEvent, Usage.output);

@@access(ResponseTextAnnotationDeltaEvent, Access.public);
@@usage(ResponseTextAnnotationDeltaEvent, Usage.output);
