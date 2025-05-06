import "@typespec/versioning";
import "../main.tsp";
import "../../typespec/files/models.tsp";

using TypeSpec.OpenAPI;
using TypeSpec.Versioning;

namespace AzureOpenAI;

@withoutOmittedProperties("status")
@added(AzureOpenAIServiceApiVersion.v2024_10_21)
model OpenAIFileWithOmittedProperties is OpenAI.OpenAIFile;

@added(AzureOpenAIServiceApiVersion.v2024_10_21)
model AzureOpenAIFile {
  ...OpenAIFileWithOmittedProperties;
  status:
    | "uploaded"
    | "pending"
    | "running"
    | "processed"
    | "error"
    | "deleting"
    | "deleted";
}

@added(AzureOpenAIServiceApiVersion.v2025_03_01_preview)
union AzureFileExpiryAnchor {
  /** Defines the anchor relative to the `created_at` time. */
  created_at: "created_at",
}

@added(AzureOpenAIServiceApiVersion.v2025_03_01_preview)
model AzureCreateFileRequest {
  ...OpenAI.CreateFileRequest;
  expires_after: {
    seconds: int32;

    @added(AzureOpenAIServiceApiVersion.v2025_03_01_preview)
    anchor: AzureFileExpiryAnchor;
  };
}

@added(AzureOpenAIServiceApiVersion.v2025_03_01_preview)
model AzureListFilesResponse {
  object: "list";
  data: AzureOpenAIFile[];
  first_id: string;
  last_id: string;
  has_more: boolean;
}
