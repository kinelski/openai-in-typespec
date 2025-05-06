using TypeSpec.OpenAPI;

namespace OpenAI;

union ListVectorStoreFilesFilter {
  string,
  "in_progress",
  "completed",
  "failed",
  "cancelled",
}

@discriminator("type")
model ChunkingStrategyResponseParam {
  type: "static" | "other";
}
