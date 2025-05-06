import "@typespec/openapi";
import "../common";

using TypeSpec.OpenAPI;

namespace OpenAI;

model ImplicitUserMessage {
  content: string | Item[];
}

/** The collection of valid roles for responses message items. */
union ResponsesMessageRole {
  system: "system",
  developer: "developer",
  user: "user",
  assistant: "assistant",
}

/** A response message item, representing a role and content. */
@discriminator("role")
model ResponsesMessage extends Item {
  /** The type of the responses item, which is always 'message'. */
  type: ItemType.message;

  @visibility("read")
  status?: "in_progress" | "completed" | "incomplete";

  /** The role associated with the message. */
  role: ResponsesMessageRole;
}

/** A message item with the `user` role. */
model ResponsesUserMessage extends ResponsesMessage {
  /** The role of the message, which is always `user`. */
  role: ResponsesMessageRole.user;

  /** The content associated with the message. */
  content: InputContent[];
}

/** A message item with the `system` role. */
model ResponsesSystemMessage extends ResponsesMessage {
  /** The role of the message, which is always `system`. */
  role: ResponsesMessageRole.system;

  /** The content associated with the message. */
  content: InputContent[];
}

/** A message item with the `developer` role. */
model ResponsesDeveloperMessage extends ResponsesMessage {
  /** The role of the message, which is always `developer`. */
  role: ResponsesMessageRole.developer;

  /** The content associated with the message. */
  content: InputContent[];
}

/** A message item with the `assistant` role. */
model ResponsesAssistantMessage extends ResponsesMessage {
  /** The role of the message, which is always `assistant`. */
  role: ResponsesMessageRole.assistant;

  /** The content associated with the message. */
  content: OutputContent[];
}

union WebSearchToolUserLocationType {
  string,
  approximate: "approximate",
}

@discriminator("type")
model WebSearchToolUserLocation {
  type: WebSearchToolUserLocationType;
}

model WebSearchToolUserLocationApproximate extends WebSearchToolUserLocation {
  type: WebSearchToolUserLocationType.approximate;
  ...WebSearchLocation;
}

@error
model ResponseErrorResponse {
  error: ResponseError;
}
